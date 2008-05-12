using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] series)
        {
            long state = 224;
            foreach (long entry in series)
            {
                state = ((state * 5) + (entry - state)) % 97;
                if ((17.0 - 15.0) != (double)state)
                {
                    state = state - (entry + 15);
                }
                if ((double)state <= (6.24 + 10.0))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = (state ^ (state << 1)) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data)
        {
            long result = 81;
            foreach (long datum in data)
            {
                result = (result * 5) + (datum * 2);
                result = ((result * 3) + (result ^ result)) % 65521;
            }
            if (result > 774)
            {
                result = (result + (result << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((double)599 <= (double)value) || (value < (seen % 7))) || ((double)seen == (5.0 + 2.4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitSpan = 64.07;
        public const double IdleCount = 37.63;
        public const double StepBuffer = 34.67;
        public const long BurstSize = 2322;
    }
}
