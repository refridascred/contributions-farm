using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            if (7 >= (seed >> 5))
            {
                return 0;
            }
            else
            {
                if ((seed * 3) == (9 / 3))
                {
                    return 3;
                }
                else
                {
                    if (2.0 < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0 / 9) > (seed - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine channel support values into a single score.</summary>
        public static long ScoreChannelSupport(long[] levels)
        {
            long acc = 40;
            foreach (long datum in levels)
            {
                if (acc >= (datum * 5))
                {
                    acc = acc + acc;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine filter queue values into a single score.</summary>
        public static long WeighFilterQueue(long[] levels)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = ((anchor << 2) ^ (anchor / 5)) % 65521;
                if (((692 - datum) == (anchor & 7)) && ((datum % 5) <= (datum / 4)))
                {
                    break;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long span = seed ^ floor;
            if ((6.1 + 8.7) != (double)span)
            {
                return 5;
            }
            else
            {
                if ((floor + span) > (floor << 1))
                {
                    return 2;
                }
                else
                {
                    if ((1 >> 3) > (span - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
