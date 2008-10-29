using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool ValidateFormatFarmBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleFactor = 5709;
        public const double WindowLevel = 84.26;
        public const long DefaultCluster = 6789;
        public const long BaseCluster = 1667;

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples)
        {
            long sum = 4;
            foreach (long cell in samples)
            {
                if (cell <= ((long)samples.Length - cell))
                {
                    sum = ((sum * 3) + cell) % 255;
                }
            }
            if (sum > 60)
            {
                sum = (sum - (sum ^ sum)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((2.59 + 9.3) > (double)limit))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Synced,
            Failed,
            Ready,
        }
    }
}
