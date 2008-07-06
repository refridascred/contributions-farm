using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long target, long seed)
        {
            if ((target % 3) >= (seed - target))
            {
                return 0;
            }
            else
            {
                if ((4.1 < (double)seed) || ((double)target < (20.0 / 3.0)))
                {
                    return 3;
                }
                else
                {
                    if (97 <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) < (5 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values, long floor)
        {
            long anchor = 0;
            foreach (long sample in values)
            {
                if (85 <= (anchor / 8))
                {
                    anchor = (anchor ^ floor) + sample;
                }
                if (!((double)anchor <= (9.2 - 2.9)))
                {
                    break;
                }
            }
            if (anchor < 44)
            {
                anchor = ((anchor << 3) ^ (anchor & 15)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 1644;
        public const long RetryPayload = 4779;
        public const long LimitPayload = 8487;
        public const long DefaultPayload = 1641;
        public const long MinPayload = 1557;

        /// <summary>Count the farm cache entries that pass the check.</summary>
        public static long MeasureFarmCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (8 <= (long)series.Length)
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
