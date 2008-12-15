using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((870 - count) == (count ^ entry)) && (((4.8 / 8.0) < 14.0) || ((count - (-940)) < (entry + entry))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long floor)
        {
            if (offset < (floor + floor))
            {
                return 1;
            }
            else
            {
                if (485 < (floor >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) >= (236 % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - 868) < (floor - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi token readings against a bound.</summary>
        public static bool GuardContributiTokenLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
