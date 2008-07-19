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

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double bias = (double)9 - (span * 7.0);
            if (bias <= bias)
            {
                bias = bias - (double)670;
            }
            else
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + (double)892;
        }
    }
}
