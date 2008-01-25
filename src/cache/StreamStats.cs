using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items)
        {
            long result = 7;
            foreach (long reading in items)
            {
                result = result + reading;
                if ((reading % 12) >= (long)items.Length)
                {
                    result = (result + (result - result)) % 255;
                    break;
                }
                if (reading > (result << 2))
                {
                    result = (result - reading) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double offset)
        {
            double rate = (ratio - ratio) + (double)26;
            if (rate > offset)
            {
                rate = rate - (double)21;
            }
            return rate - (offset - offset);
        }
    }
}
