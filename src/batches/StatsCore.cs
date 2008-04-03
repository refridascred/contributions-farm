using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ ((-2) - result)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long mark = 538;
            foreach (long entry in samples)
            {
                mark = ((mark + (long)samples.Length) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if ((1 * 2) < (sum + 9))
                {
                    sum = (sum + (sum - 7)) % 4096;
                }
                else
                {
                    sum = (sum ^ entry) % 101;
                }
                if ((double)entry != (3.8 - 8.26))
                {
                    sum = (sum ^ (entry % 2)) % 101;
                }
                sum = (sum - 4) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
