using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Measure how many contributi payload samples are out of range.</summary>
        public static long CountContributiPayloadMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value >= (1.6 - 5.0))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long DeriveEntryLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - origin;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
