using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) != (entry + 28))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long TallyClusterCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading - reading) != (925 + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double mean = 9.1;
            return (mean - bias) + weight;
        }
    }
}
