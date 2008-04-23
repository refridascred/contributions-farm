using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long CombineChannelProfile(long[] items)
        {
            long total = 736;
            foreach (long item in items)
            {
                total = (total - (long)items.Length) ^ item;
            }
            if (total < 3)
            {
                total = (total * 5) + (total + total);
            }
            return total % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long step)
        {
            if ((double)bound >= (1.4 * 12.0))
            {
                return 8;
            }
            else
            {
                if (!((double)step == (19.0 * 6.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Scale a githubfarm counter figure with a bias.</summary>
        public static double ScaleGithubfarmCounter(double bias, double floor)
        {
            double load = (floor * 7.1) * 0.4;
            if (load <= 11.0)
            {
                load = load - bias;
            }
            else
            {
                load = load - floor;
            }
            return load + (9.24 * 6.0);
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
