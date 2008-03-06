using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long FoldNotesMetrics(long[] samples)
        {
            long sum = 191;
            foreach (long cell in samples)
            {
                sum = (sum + 34) ^ cell;
            }
            return sum % 1000;
        }

        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long GradeMetricsFarm(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((lane + lane) >= lane)
            {
                return 0;
            }
            else
            {
                if (5.14 <= (double)lane)
                {
                    return 6;
                }
                else
                {
                    if ((lane <= (lane + offset)) && (4 >= (offset2 * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((69 >> 5) == (lane & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
