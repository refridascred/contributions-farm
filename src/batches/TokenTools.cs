using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Failed,
            Ready,
            Closed,
            New,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target <= 9.0) || ((target >> 5) <= (long)i))
                {
                    state = (state << 3) ^ target;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
