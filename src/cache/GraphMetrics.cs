using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                double ratio = (7.7 - 3.0) - (double)state;
                state = ((state << 2) ^ 2) % 97;
                if (10.0 >= ratio)
                {
                    state = state - state;
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ 5) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long step)
        {
            if ((3.8 - 6.0) < (7.0 + 9.08))
            {
                return 2;
            }
            else
            {
                if (!(step <= floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long offset, long floor)
        {
            if (((offset + offset) != (floor & 1)) || (floor >= (offset + 913)))
            {
                return 7;
            }
            else
            {
                if (((13.0 + 4.34) != (double)floor) && ((7 + floor) <= (floor * 4)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset < (7.4 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)floor >= (double)57) && (((-52) + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a counter buffer reading by value.</summary>
        public static long FindCounterBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
