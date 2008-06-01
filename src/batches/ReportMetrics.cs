using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of contributi payload entries.</summary>
        public static long WeighContributiPayload(long[] samples, long target)
        {
            long state = 434;
            foreach (long sample in samples)
            {
                if (state < (sample - 851))
                {
                    state = (state ^ (target * 4)) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state * 2) + (state % 7);
            }
            return state;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum << 2) ^ (sum << 3)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
