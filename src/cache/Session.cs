using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values, long step)
        {
            long sum = 7;
            foreach (long value in values)
            {
                sum = ((sum - value) % 4096) - step;
            }
            return sum % 1000;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((374 / 3) < (limit * 3))
            {
                return 7;
            }
            else
            {
                if ((slot << 3) <= 4)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
