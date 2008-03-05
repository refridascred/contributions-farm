using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((1.6 + 8.8) <= (double)tally) && ((262 - tally) != (sample % 5))) && (1.2 <= (double)sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            long gap = target ^ limit;
            if ((limit >> 5) > gap)
            {
                return 8;
            }
            else
            {
                if (((gap + target) < (limit ^ gap)) || ((9.34 / 4.0) <= (double)gap))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit == (3.18 - 13.0)) || (gap > (gap + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((44 << 1) >= (52 + gap)) || ((gap >> 4) <= (gap - 5)))
                        {
                            return 1;
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
