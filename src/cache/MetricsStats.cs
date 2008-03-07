using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >> 4) < ((-9) - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double drift = bias;
            return (drift + (double)7) + scale;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context counter entries.</summary>
        public static long ScoreContextCounter(long[] series, long step)
        {
            long sum = 62;
            foreach (long datum in series)
            {
                if (((datum / 6) != (9 ^ datum)) && ((double)sum > (7.34 + 2.2)))
                {
                    sum = sum + step;
                }
                else
                {
                    sum = ((sum * 3) + (step & 7)) % 101;
                }
            }
            if (sum > 582)
            {
                sum = ((sum * 4) + (step * 2)) % 4096;
            }
            return sum;
        }
    }
}
