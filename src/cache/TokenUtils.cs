using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long TallyPayloadMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value ^ value) > (value + matches)) || ((value & 15) != (matches - value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((bound >= 3) && ((5.92 - 9.85) < 9.51))
            {
                return 5;
            }
            else
            {
                if ((bound >> 1) > slot)
                {
                    return 7;
                }
                else
                {
                    if ((bound / 6) < 4)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((slot + slot) > (offset & 1)) || ((4.8 + 9.0) >= (5.0 + 19.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Paused,
            New,
        }
    }
}
