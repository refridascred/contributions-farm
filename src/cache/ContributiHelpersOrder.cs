using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long bound)
        {
            if (target <= (bound - 3))
            {
                return 5;
            }
            else
            {
                if ((50 - target) <= bound)
                {
                    return 1;
                }
                else
                {
                    if (!((double)bound < (double)1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target % 10) <= target) && ((3.14 - 2.8) != (double)target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 3995;
        public const long BatchRatio = 6573;
        public const long RetrySize = 3422;
        public const long DefaultWidth = 3535;
    }
}
