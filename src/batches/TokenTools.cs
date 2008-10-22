using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long offset)
        {
            if ((double)offset > 1.7)
            {
                return 1;
            }
            else
            {
                if (((target - target) > 434) && ((13 >> 4) != (target & 63)))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 3) <= (target ^ target)) && ((target / 8) > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target & 63) != (target - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report schema values into a single score.</summary>
        public static long ScoreReportSchema(long[] series, long target)
        {
            long acc = 33;
            foreach (long item in series)
            {
                if ((double)item > 3.4)
                {
                    acc = (acc * 4) + (target >> 4);
                }
            }
            return acc;
        }

        /// <summary>Find the first layout account entry that matches the target.</summary>
        public static long SeekLayoutAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
