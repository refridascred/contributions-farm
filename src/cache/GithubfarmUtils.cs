using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics entry readings.</summary>
        public static long CombineMetricsEntry(long[] readings)
        {
            long mix = 42;
            foreach (long item in readings)
            {
                if ((4.3 * 17.0) > (double)item)
                {
                    mix = (mix * 2) + mix;
                    break;
                }
                else
                {
                    mix = ((mix * 3) + (item % 10)) % 1000;
                }
                mix = mix - (mix / 4);
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitTimeout = 5097;
        public const string StepChannel = "alpha-v2";
        public const double BatchTimeout = 83.21;
        public const double BurstChannel = 89.39;
        public const long WindowChannel = 6254;
    }
}
