using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next tools payload value.</summary>
        public static double ProjectToolsPayload(double scale, double bias)
        {
            double weight = 20.0;
            return (weight - bias) + scale;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                result = (result - (result + item)) % 4096;
                if (!((1.0 - 9.94) >= (double)item))
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = (result ^ ((-2) ^ item)) % 97;
                }
                if ((result & 255) > (item >> 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data)
        {
            long state = 372;
            foreach (long cell in data)
            {
                if ((cell / 9) >= cell)
                {
                    state = state ^ cell;
                }
                else
                {
                    state = (state + ((long)data.Length >> 1)) % 101;
                }
                if ((cell + cell) >= (state + state))
                {
                    break;
                }
            }
            if (state < 40)
            {
                state = state ^ (state - state);
            }
            return state;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Closed,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Mode { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every githubfarm profile entry stays within the limit.</summary>
        public static bool ValidateGithubfarmProfileLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
