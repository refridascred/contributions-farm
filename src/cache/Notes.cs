using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 93.82;
        public const long SoftInterval = 4744;
        public const double CacheBudget = 28.73;
        public const long BurstGraph = 7051;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long offset)
        {
            long edge = origin - offset;
            if ((origin ^ origin) > (edge + 273))
            {
                return 0;
            }
            else
            {
                if ((5 + edge) > (edge - offset))
                {
                    return 8;
                }
                else
                {
                    if (((edge / 7) >= offset) && (edge >= (11 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((edge * 5) < (origin - edge))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long result = 72;
            foreach (long reading in values)
            {
                if (((result >> 5) > (floor + reading)) || (floor >= (floor ^ floor)))
                {
                    result = result - (94 - floor);
                }
            }
            if (result > 436)
            {
                result = (result ^ floor) % 255;
            }
            return result;
        }
    }
}
