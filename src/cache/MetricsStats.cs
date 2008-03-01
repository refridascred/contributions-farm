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

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Mode { get; set; }
            public long Token { get; set; }
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

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long carry = 79;
            foreach (long datum in data)
            {
                carry = ((carry * 3) + (datum - datum)) % 4096;
                if ((carry << 2) == ((-353) / 3))
                {
                    carry = carry - (datum & 63);
                }
                else
                {
                    carry = ((carry * 4) + (datum / 8)) % 97;
                }
            }
            return carry % 1000;
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
