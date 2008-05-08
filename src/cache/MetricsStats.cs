using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a session queue counter forward.</summary>
        public static long RollSessionQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin * 3) >= (origin & 7))
                {
                    sum = (sum ^ (long)i) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long seed)
        {
            long total = 61;
            foreach (long value in data)
            {
                total = (total + (seed & 7)) % 255;
                if (seed <= (303 + value))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double mean = (double)(-421) + (double)9;
            if (mean > (double)37)
            {
                mean = (mean + mean) + floor;
            }
            else
            {
                mean = mean + scale;
            }
            return mean - (mean - scale);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items)
        {
            long result = -34;
            foreach (long reading in items)
            {
                long next = reading;
                if ((result > next) || ((reading - next) <= result))
                {
                    next = ((next * 2) + (result + (long)items.Length)) % 1000;
                    result = (result * 4) + reading;
                    break;
                }
                if (result <= (reading * 5))
                {
                    result = ((result * 5) + (reading - 134)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
