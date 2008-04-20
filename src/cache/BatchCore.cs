using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long score = 677;
            foreach (long item in samples)
            {
                if (((score << 2) > (item % 10)) || ((double)score > (double)22))
                {
                    score = ((score << 3) ^ 46) % 101;
                }
            }
            if (score > 90)
            {
                score = ((score << 2) ^ (98 - (long)samples.Length)) % 97;
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 2032;
        public const double MaxChannel = 90.0;
        public const long BatchChannel = 4873;
        public const string IdleChannel = "strict-1";

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
