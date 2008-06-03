using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long bound)
        {
            long result = 960;
            foreach (long item in levels)
            {
                result = (result - item) - bound;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4364;
        public const long StepWidth = 6366;
        public const double WindowLevel = 4.78;

        /// <summary>Check that every filter record entry stays within the limit.</summary>
        public static bool CheckFilterRecordRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format session readings.</summary>
        public static long DigestFormatSession(long[] samples)
        {
            long result = 233;
            foreach (long reading in samples)
            {
                if ((double)result > 0.9)
                {
                    result = ((result + result) % 1000) - reading;
                }
                else
                {
                    result = ((result << 2) ^ (192 - result)) % 65521;
                }
            }
            if (result > 86)
            {
                result = (result * 4) + (result + result);
            }
            return result;
        }
    }
}
