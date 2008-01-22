using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((gap / 4) > offset)
            {
                return 6;
            }
            else
            {
                if (((bound * 5) != (gap - bound)) && ((890 - gap) == (185 & 127)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values, long target)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                carry = ((((carry << 3) ^ (carry / 2)) % 1000) - reading) - target;
                if (((4 + carry) >= (60 / 9)) && ((carry % 2) <= carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
