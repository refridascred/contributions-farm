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

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long carry = 808;
            foreach (long value in samples)
            {
                carry = (carry + (value >> 3)) % 97;
            }
            return carry % 4096;
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

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                sum = (sum - (sum - sum)) + reading;
            }
            if (sum < 85)
            {
                sum = sum - (0 >> 2);
            }
            return sum;
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
