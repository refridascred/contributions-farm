using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            long lane = floor - floor2;
            if (((double)lane == (double)floor2) && ((lane % 24) != (floor >> 2)))
            {
                return 8;
            }
            else
            {
                if (((5.55 * 8.9) >= (double)lane) || ((lane - floor2) != (floor2 << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (19.0 + 8.9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series)
        {
            long state = 4;
            foreach (long value in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state * 2) + (110 + state)) ^ (long)i;
                }
                if (((-2) <= (state << 2)) && ((value - state) < value))
                {
                    state = (state - (value + value)) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state + state) % 97;
            }
            return state % 65521;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Stale,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record window value from a seed.</summary>
        public static long SeriesRecordWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
