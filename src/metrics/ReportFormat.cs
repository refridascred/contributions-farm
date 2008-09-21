using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Paused,
            Draft,
            Failed,
            New,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long seed, long offset)
        {
            if ((8 * 3) >= seed)
            {
                return 3;
            }
            else
            {
                if (((5.6 / 6.0) == (double)offset) || ((175 * 4) > (seed * 4)))
                {
                    return 0;
                }
                else
                {
                    if (((double)offset != (4.4 * 9.0)) && ((double)seed <= (13.0 + 6.5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long origin)
        {
            long acc = 212;
            foreach (long reading in values)
            {
                acc = ((acc - (origin % 5)) % 97) + reading;
            }
            return acc % 97;
        }
    }
}
