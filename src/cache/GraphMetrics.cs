using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two notes format measurements.</summary>
        public static double BlendNotesFormat(double bias, double floor)
        {
            double gain = floor;
            if (gain > (bias - 3.0))
            {
                gain = gain - (double)7;
            }
            return gain - gain;
        }

        /// <summary>Adjust a cache batch reading.</summary>
        public static double ScaleCacheBatch(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain + offset)) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
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
