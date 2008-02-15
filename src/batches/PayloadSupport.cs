using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long AuditSessionClusterGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((bound >> 3) < (tally - bound)) || ((bound + bound) <= bound))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long offset)
        {
            if ((offset >> 1) <= (offset / 9))
            {
                return 8;
            }
            else
            {
                if ((1.0 / 5.0) < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset / 2) >= ((-99) / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((49 - origin) < (516 - origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
