using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long target)
        {
            long mix = 119;
            foreach (long cell in samples)
            {
                if ((99 % 8) > (mix - target))
                {
                    mix = (mix ^ cell) % 255;
                }
            }
            if (mix > 986)
            {
                mix = (mix - 503) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ seed) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
