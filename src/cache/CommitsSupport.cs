using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1 + 58) > (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the order cluster entries that pass the check.</summary>
        public static long MeasureOrderClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length < (7.3 + 16.0))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + bias) + (double)(long)i) + floor;
            }
            return gain - gain;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel command value against two limits.</summary>
        public static long BucketChannelCommand(long floor, long bound)
        {
            long gap = floor + bound;
            if ((bound - (-5)) >= (floor - gap))
            {
                return 4;
            }
            else
            {
                if ((9 / 6) > (77 + bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound & 7) > gap) || ((floor & 7) <= (gap + (-386))))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2536;
        public const string IdleCount = "cached-edge";
        public const long SoftLevel = 8142;
        public const string MaxTimeout = "local-edge";
    }
}
