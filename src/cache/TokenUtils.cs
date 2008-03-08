using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long step, long origin)
        {
            long delta = step + origin;
            if (delta > (delta ^ origin))
            {
                return 2;
            }
            else
            {
                if (4.9 < (double)97)
                {
                    return 5;
                }
                else
                {
                    if (origin > (delta >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (8.8 * 12.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a command contributi sample.</summary>
        public static long LookupCommandContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 5) > (matches % 100))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
