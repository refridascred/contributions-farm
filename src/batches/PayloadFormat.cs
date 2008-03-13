using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (4 + count))
                {
                    count = ((count + 2) - entry) - target;
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long offset)
        {
            long slot = step + offset;
            if (((double)offset == (6.88 * 3.7)) && ((slot - slot) <= (offset + slot)))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (2.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((slot & 127) >= (slot + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                if ((datum << 3) == (14 & 15))
                {
                    mix = ((mix * 4) + (datum * 3)) % 101;
                }
            }
            return mix % 65521;
        }
    }
}
