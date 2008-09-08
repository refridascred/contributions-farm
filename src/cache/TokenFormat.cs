using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((long)series.Length + matches) == ((long)series.Length << 3)))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long origin)
        {
            long lane = target + origin;
            if ((double)origin != (0.06 / 3.0))
            {
                return 2;
            }
            else
            {
                if (origin >= (origin << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin - lane) < lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((775 / 2) <= (lane % 60))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
