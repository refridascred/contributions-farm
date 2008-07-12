using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache entry pair into a bucket.</summary>
        public static long ClassifyCacheEntry(long origin, long limit)
        {
            if (origin <= limit)
            {
                return 3;
            }
            else
            {
                if ((922 - limit) < (origin + limit))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin > (8.38 + 2.0)) && ((0.7 - 5.5) > (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first profile report entry that matches the target.</summary>
        public static long SeekProfileReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits window value from a seed.</summary>
        public static long StepCommitsWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ ((long)i - (long)i);
                if (!((1 & 255) == (result ^ 6)))
                {
                    result = result ^ (2 % 7);
                }
                if ((result - 3) == (5 + (long)i))
                {
                    result = ((result << 2) ^ (result ^ result)) % 65521;
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
