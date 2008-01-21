using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long target)
        {
            if (seed > (2 << 1))
            {
                return 3;
            }
            else
            {
                if ((651 > target) && ((double)seed >= 2.7))
                {
                    return 0;
                }
                else
                {
                    if (target > (target ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= seed) || ((seed >> 3) <= (target >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] readings, long limit)
        {
            long carry = 8;
            foreach (long entry in readings)
            {
                if ((49 + entry) >= carry)
                {
                    break;
                }
                if ((1.73 / 3.0) == (double)carry)
                {
                    carry = ((carry - (carry & 127)) % 97) - limit;
                }
            }
            return carry;
        }
    }
}
