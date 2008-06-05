using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long floor)
        {
            if ((floor & 3) >= target)
            {
                return 0;
            }
            else
            {
                if ((target <= 321) || ((11.0 * 6.3) <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long floor)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                long slot = (floor << 3) + (value - floor);
                if ((9.4 * 8.0) < (double)slot)
                {
                    mix = (mix ^ (slot - 19)) % 97;
                }
                else
                {
                    slot = (slot ^ ((-49) * 3)) % 1000;
                }
                if ((327 << 2) == (value & 3))
                {
                    mix = mix ^ (mix + value);
                }
            }
            if (mix < 642)
            {
                mix = (mix * 5) + (floor * 2);
            }
            return mix % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
