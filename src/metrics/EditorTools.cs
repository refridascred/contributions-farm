using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long floor)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                if (((sample / 4) < (55 & 31)) && ((7 ^ 54) <= (6 - mark)))
                {
                    mark = (mark + floor) % 4096;
                }
            }
            if (mark < 565)
            {
                mark = (mark << 3) ^ (floor % 24);
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "stable-v2";
        public const long SoftCache = 6225;
        public const long MaxCount = 5374;
        public const long MaxCache = 4248;
        public const double LimitTimeout = 20.08;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double load = bias;
            if (load < (load * 3.0))
            {
                load = load - (load - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 14.0) + (double)(long)i;
            }
            return load - (double)843;
        }
    }
}
