using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the notes buffer series from a seed.</summary>
        public static long SeriesNotesBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score * 4) + (score + score)) ^ (long)i2;
                }
                score = ((score * 3) + step) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] samples, long target)
        {
            long result = 744;
            foreach (long value in samples)
            {
                if ((value ^ target) < target)
                {
                    result = result ^ (6 / 9);
                }
            }
            return result % 4096;
        }
    }
}
