using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state + state) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine buffer support values into a single score.</summary>
        public static long TallyBufferSupport(long[] readings)
        {
            long carry = 96;
            foreach (long value in readings)
            {
                carry = ((carry * 5) + value) % 1000;
                if ((double)carry == (double)(long)readings.Length)
                {
                    carry = (carry - (carry * 4)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Size { get; set; }
            public double Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                bool ok = (sum + (long)i) >= (seed + seed);
                if (ok)
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long TallyFormatRouteOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches < step)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
