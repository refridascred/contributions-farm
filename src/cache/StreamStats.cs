using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long seed)
        {
            if ((offset + seed) <= (seed & 255))
            {
                return 5;
            }
            else
            {
                if ((seed / 9) <= (9 + seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed + offset) > (seed - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (4.0 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 761;
        public const long RetryScore = 8602;
        public const string MaxRatio = "cached";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first filter token entry that matches the target.</summary>
        public static long LocateFilterTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
