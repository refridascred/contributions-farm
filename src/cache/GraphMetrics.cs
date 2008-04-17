using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double ratio, double floor)
        {
            double rate = ratio;
            if (rate >= ratio)
            {
                rate = rate - (floor + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (floor / 5.0);
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((245 - datum) == ((long)samples.Length ^ 91)) && (((seed + seed) <= (datum & 3)) && ((tally / 5) == (tally + seed))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            long next = seed + bound;
            if ((next * 3) <= (next >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)next >= (3.3 - 0.7))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
