using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            New,
            Paused,
            Active,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((offset <= 45) && (((double)reading <= 2.98) || ((reading & 31) <= 43)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((sample & 3) >= matches) || ((sample << 1) > (sample + matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
