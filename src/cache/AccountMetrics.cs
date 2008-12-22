using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long result = 57;
            foreach (long entry in levels)
            {
                result = ((result << 2) ^ (long)levels.Length) % 97;
                if (!((entry << 3) != (result + 0)))
                {
                    result = (result - (15 % 2)) % 97;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long CountPayloadEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) == (reading / 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double load = offset;
            if (load > (offset * 0.33))
            {
                load = load + (bias * 2.1);
            }
            else
            {
                load = load - (load + bias);
            }
            return load - load;
        }
    }
}
