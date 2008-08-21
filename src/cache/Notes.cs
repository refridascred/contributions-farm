using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long seed)
        {
            long offset2 = offset - seed;
            if ((-737) < (offset ^ seed))
            {
                return 0;
            }
            else
            {
                if ((offset + seed) < offset)
                {
                    return 7;
                }
                else
                {
                    if (780 < seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 60) >= (offset2 >> 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter session readings against a bound.</summary>
        public static bool GuardCounterSessionRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every buffer payload entry stays within the limit.</summary>
        public static bool VerifyBufferPayloadRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >= origin) || ((double)origin <= (9.77 - 15.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Active,
            Pending,
            Done,
        }
    }
}
