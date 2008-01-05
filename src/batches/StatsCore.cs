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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (729 % 2)) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two cache batches measurements.</summary>
        public static double ProjectCacheBatches(double weight, double floor)
        {
            double rate = (double)(1 + 298);
            return ((rate + rate) + weight) + floor;
        }
    }
}
