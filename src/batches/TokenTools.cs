using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long step)
        {
            if (((double)step < (8.0 + 12.0)) && ((5 >> 5) != (floor + step)))
            {
                return 5;
            }
            else
            {
                if ((double)797 > (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (2.08 * 0.18))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 3) <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double offset)
        {
            double load = gain * 0.2;
            return (load + (load + gain)) + offset;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
