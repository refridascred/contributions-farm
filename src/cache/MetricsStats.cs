using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftSpan = 43.14;
        public const long SoftSize = 469;
        public const double LimitSpan = 80.52;
        public const long HardWidth = 5629;
        public const long LimitLayout = 1405;

        /// <summary>Digest a series of metrics already entries.</summary>
        public static long TallyMetricsAlready(long[] items)
        {
            long state = 45;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ (1 ^ state)) - reading;
                if ((state ^ state) > state)
                {
                    state = state - (state ^ state);
                }
                else
                {
                    state = ((state << 3) ^ (945 << 2)) % 97;
                }
            }
            if (state < 378)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if (mix > (26 / 2))
                {
                    mix = ((mix * 4) + ((long)i + limit)) % 255;
                    mix = (mix * 5) + mix;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((reading / 2) > reading) || (matches < (matches & 63)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine checks notes values into a single score.</summary>
        public static long CombineChecksNotes(long[] items, long seed)
        {
            long result = 0;
            foreach (long value in items)
            {
                if (!(seed <= (result + value)))
                {
                    result = result - (value * 4);
                }
            }
            return result;
        }
    }
}
