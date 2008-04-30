using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a report editor sample.</summary>
        public static long SeekReportEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = state - state;
                state = ((state * 4) + (state + state)) % 1000;
                if ((551 ^ (long)i) > origin)
                {
                    state = (state ^ (origin ^ 501)) % 97;
                    state = (state + (state + state)) % 1000;
                }
                else
                {
                    state = state ^ 34;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
