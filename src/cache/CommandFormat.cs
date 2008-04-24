using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of already commits readings.</summary>
        public static long TallyAlreadyCommits(long[] samples)
        {
            long score = 40;
            foreach (long sample in samples)
            {
                if ((score ^ score) >= (sample - sample))
                {
                    score = score ^ sample;
                }
                else
                {
                    score = (score << 3) ^ (sample % 3);
                }
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
