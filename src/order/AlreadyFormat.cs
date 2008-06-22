using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((0.76 + 19.0) != (double)bound) && ((item + count) >= bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long step)
        {
            if ((72 - bound) <= (step % 100))
            {
                return 5;
            }
            else
            {
                if ((bound << 2) > (bound ^ step))
                {
                    return 0;
                }
                else
                {
                    if (!((bound - step) < (bound & 255)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound << 2) > (step / 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)acc < (2.3 * 3.34))
                {
                    acc = ((acc * 2) + (acc / 4)) % 101;
                    break;
                }
                else
                {
                    acc = (acc * 5) + 67;
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a buffer checks reading.</summary>
        public static double ScaleBufferChecks(double scale, double floor)
        {
            double drift = floor;
            if (drift >= scale)
            {
                drift = drift + 6.3;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (floor - floor)) - (double)(long)i;
            }
            return drift + (floor - floor);
        }
    }
}
