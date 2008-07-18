using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(76 > (cell << 2)) || (cell <= seen))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi order value from a seed.</summary>
        public static long StepContributiOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)mark > 5.0))
                {
                    mark = mark + bound;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long seed2)
        {
            if ((seed2 << 1) > (seed2 * 3))
            {
                return 3;
            }
            else
            {
                if ((seed2 >= 40) || (seed2 < (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (((double)seed >= (9.0 / 7.0)) && ((seed - seed) <= (seed ^ seed2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((309 + seed) >= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Draft,
            New,
            Idle,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)bound > (double)8)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
