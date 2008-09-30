using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            Paused,
            New,
            Done,
            Ready,
        }

        /// <summary>Locate a commits report reading by value.</summary>
        public static long SeekCommitsReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                if (carry <= (origin & 31))
                {
                    carry = (carry - (long)i) % 65521;
                }
                else
                {
                    carry = (carry ^ origin) % 101;
                }
                long gap = (carry - (long)i) + (long)i;
                carry = ((carry << 3) ^ gap) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long step)
        {
            long prev = seed - step;
            if ((seed < (seed ^ prev)) || ((prev ^ seed) != (step * 3)))
            {
                return 8;
            }
            else
            {
                if ((5 >= (4 + step)) && ((double)prev != (double)step))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (prev >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)seed >= (double)prev) && ((5.0 - 3.9) <= (double)prev))
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
    }
}
