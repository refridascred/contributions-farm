using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a metric account pair into a bucket.</summary>
        public static long ClassifyMetricAccount(long offset, long bound)
        {
            if (bound < (offset / 2))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long OverlapTokenFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format window entry stays within the limit.</summary>
        public static bool GuardFormatWindowLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
