using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double offset)
        {
            double mean = (double)(7 - (-7));
            if (mean < (bias - mean))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "local";
        public const string RetrySpan = "alpha-1";
        public const string BurstDepth = "open-edge";

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                long seen = (long)i * 4;
                if (limit > (limit - seen))
                {
                    continue;
                }
                else
                {
                    seen = (seen ^ (seen / 7)) % 4096;
                }
                seen = seen - acc;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long WeighNotesSchema(long[] items, long target)
        {
            long state = 268;
            foreach (long value in items)
            {
                if (((585 / 4) != (state ^ target)) && (target <= (state + state)))
                {
                    state = ((state << 3) ^ (value + value)) % 1000;
                }
                if ((state - 25) > target)
                {
                    state = state + (value / 4);
                }
                else
                {
                    state = state ^ (state % 2);
                }
            }
            if (state < 43)
            {
                state = (state << 3) ^ (60 / 8);
            }
            return state % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long state = 555;
            foreach (long reading in values)
            {
                state = state - (30 << 1);
                if ((state * 5) > reading)
                {
                    state = ((state * 2) + 91) % 101;
                }
                else
                {
                    state = ((state * 4) + (state >> 3)) % 255;
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state * 4)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Stale,
            Closed,
            Paused,
            Failed,
        }
    }
}
