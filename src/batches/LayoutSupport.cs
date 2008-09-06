using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a metrics checks sample.</summary>
        public static long LookupMetricsChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ 2;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((4.12 * 2.0) <= (0.24 - 5.17)) && ((20 % 8) == (value + seen))) && (((seen - value) < (seen ^ value)) || ((seen % 3) < value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = state - (long)i;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
