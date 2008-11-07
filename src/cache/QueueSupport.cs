using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if ((step - 788) <= (step + (long)i))
                {
                    total = (total * 4) + (step * 2);
                    break;
                }
                else
                {
                    total = ((total << 3) ^ (total - (long)i)) % 4096;
                }
                total = total - (total << 3);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long bound)
        {
            long acc = 87;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + (sample & 31)) % 4096) - bound;
            }
            if (acc > (-982))
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }
    }
}
