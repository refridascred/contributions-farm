using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items, long offset)
        {
            long carry = 6;
            foreach (long reading in items)
            {
                if ((7.3 * 18.0) < (double)carry)
                {
                    carry = (((carry * 5) + (375 >> 2)) - reading) - offset;
                }
            }
            return carry % 4096;
        }

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((offset + floor) >= (next >> 4))
            {
                return 3;
            }
            else
            {
                if ((offset % 100) <= (-550))
                {
                    return 8;
                }
                else
                {
                    if ((5 + floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((229 + next) == (next % 24))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((8.0 / 8.0) > (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
