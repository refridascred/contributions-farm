using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a profile payload pair into a bucket.</summary>
        public static long RankProfilePayload(long step, long target)
        {
            if ((step / 9) <= step)
            {
                return 8;
            }
            else
            {
                if ((double)target < (double)step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate route entry readings against a bound.</summary>
        public static bool VerifyRouteEntryRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
