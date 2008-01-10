using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((limit / 9) > 873)
            {
                return 8;
            }
            else
            {
                if ((19.0 + 1.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((bound % 64) >= (lane % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((lane / 5) == (lane / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next farm command value.</summary>
        public static double ScaleFarmCommand(double weight, double floor)
        {
            double mean = weight;
            return mean - floor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) > (15 * 2))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
