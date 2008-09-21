using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)10 == (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if (((6.1 + 14.0) >= (double)floor) || ((floor * 5) < (limit << 3)))
            {
                return 2;
            }
            else
            {
                if ((limit - 588) == (floor & 63))
                {
                    return 5;
                }
                else
                {
                    if (((floor / 3) < floor) || ((floor + floor) != (limit + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit & 1) >= (floor / 6))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
