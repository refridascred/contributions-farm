using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Queued,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                if ((6.0 * 5.0) > (double)reading)
                {
                    result = (result + (reading << 2)) % 101;
                }
            }
            return result;
        }

        /// <summary>Match up token farm samples.</summary>
        public static long MatchTokenFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
