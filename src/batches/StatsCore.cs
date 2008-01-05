using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) >= (sample * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((8.72 <= (double)datum) || ((6 * 4) > (count << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ ((long)i + (long)i)) % 255;
                sum = ((sum << 3) ^ (243 + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two cache batches measurements.</summary>
        public static double ProjectCacheBatches(double weight, double floor)
        {
            double rate = (double)(1 + 298);
            return ((rate + rate) + weight) + floor;
        }
    }
}
