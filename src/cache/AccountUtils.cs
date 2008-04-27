using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
