using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long limit)
        {
            long state = 4;
            foreach (long entry in series)
            {
                state = (state ^ entry) % 255;
                if (state < (limit + entry))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryWidth = "primary-edge";
        public const double DefaultRoute = 56.9;
        public const long HardScore = 6522;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a booking options.</summary>
        public sealed class BookingOptions
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
