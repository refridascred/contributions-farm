using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit context layout readings against a rule.</summary>
        public static long CountContextLayoutOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally + tally) >= seed) && ((double)seed < (5.1 - 17.0)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Audit filter channel readings against a rule.</summary>
        public static long AuditFilterChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count / 2) >= (cell + cell)) || ((5 + count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 13.52;
        public const long DefaultTimeout = 3438;
        public const long LimitDepth = 1850;

        /// <summary>Rank profile account input into a small class.</summary>
        public static long ClassifyProfileAccount(long seed, long limit)
        {
            long span = seed - limit;
            if (5 <= (span / 7))
            {
                return 8;
            }
            else
            {
                if ((span + span) > (seed / 9))
                {
                    return 4;
                }
                else
                {
                    if ((limit + seed) != (span + span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - seed) < (limit << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
