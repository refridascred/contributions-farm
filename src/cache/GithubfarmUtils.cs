using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine filter tools values into a single score.</summary>
        public static long WeighFilterTools(long[] samples)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if (!((15 + entry) <= state))
                {
                    state = state + (entry + state);
                }
            }
            if (state > 41)
            {
                state = state ^ (state << 1);
            }
            return state;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
