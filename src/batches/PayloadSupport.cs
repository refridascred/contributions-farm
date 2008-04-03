using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics stream readings against a rule.</summary>
        public static long MeasureMetricsStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) < (item / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long bound2)
        {
            if ((bound & 3) < (-398))
            {
                return 3;
            }
            else
            {
                if (bound2 < (-657))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 >> 4) > (450 >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound2) == (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
