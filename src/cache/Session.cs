using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double load = offset + (double)79;
            if (load >= bias)
            {
                load = load + (bias - 2.0);
            }
            return load - (load * 4.1);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the report batches series from a seed.</summary>
        public static long IterateReportBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 2) ^ floor) % 65521;
                if (score >= (floor << 3))
                {
                    score = ((score * 5) + (score - (long)i)) % 97;
                    score = (score ^ (56 / 3)) % 4096;
                }
                score = ((score * 5) + (score + (long)i)) % 97;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3954;
        public const double SoftQueue = 1.96;
        public const long LimitQueue = 1624;
    }
}
