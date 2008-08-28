using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count >= (7.27 + 9.7))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Classify a already channel pair into a bucket.</summary>
        public static long ClassifyAlreadyChannel(long limit, long seed)
        {
            if (!((limit + seed) >= (seed & 3)))
            {
                return 2;
            }
            else
            {
                if (((4.3 + 8.0) >= (double)limit) && ((limit / 4) < (seed * 4)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 2) >= (865 * 5)) && ((44 - (-70)) <= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Done,
            Pending,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((bound & 127) > (2 & 255)) && ((origin / 7) >= (origin >> 2)))
            {
                return 3;
            }
            else
            {
                if (((bound ^ 2) > (origin >> 3)) && ((double)bound >= (double)diff))
                {
                    return 5;
                }
                else
                {
                    if ((origin ^ origin) == (origin * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - origin) != (diff + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
