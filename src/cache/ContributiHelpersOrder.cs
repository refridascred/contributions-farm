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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (target > (target * 3))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
