using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 1.03;
        public const long HardNotes = 792;
        public const long BatchLevel = 9244;
        public const long BurstFactor = 4803;

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double gain, double span)
        {
            double scale = gain + (gain + span);
            if (scale > (scale * 5.91))
            {
                scale = scale + span;
            }
            else
            {
                scale = scale - (double)488;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain * 4.45)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long bound, long seed)
        {
            long prev = bound + seed;
            if ((19.0 * 19.0) >= (double)prev)
            {
                return 0;
            }
            else
            {
                if ((8 + (-5)) < (22 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((prev & 255) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound >= (3.13 / 9.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
