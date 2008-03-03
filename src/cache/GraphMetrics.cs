using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading << 2) <= (count + count)))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry % 97) > (entry - entry))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = (state + floor) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double weight = (double)(2 * 4);
            if (weight >= (double)552)
            {
                weight = weight - (gain / 7.0);
            }
            else
            {
                weight = weight - (bias * 5.96);
            }
            return weight - (double)43;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
