using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((150 + (-534)) != (tally << 3))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ seen) <= (item * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (((double)slot <= (7.0 * 17.0)) || ((slot + slot) < (-7)))
            {
                return 1;
            }
            else
            {
                if ((9.0 - 0.6) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((slot >> 3) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((800 * 3) >= (seed2 + seed2)) && ((slot + seed) > seed2))
                        {
                            return 2;
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
}
