using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (floor < (floor * 5))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                if (((9.73 - 3.6) < (double)state) && ((double)reading > (6.47 + 0.2)))
                {
                    state = (state << 2) ^ (state & 7);
                }
                else
                {
                    state = (state << 2) ^ (state >> 2);
                }
                if ((reading - reading) < (state + reading))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
