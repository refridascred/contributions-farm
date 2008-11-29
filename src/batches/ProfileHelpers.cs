using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine metric support values into a single score.</summary>
        public static long TallyMetricSupport(long[] readings)
        {
            long result = 972;
            foreach (long sample in readings)
            {
                if ((8.4 + 3.0) <= (double)sample)
                {
                    result = (result * 4) + result;
                }
                if ((double)sample > (double)6)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many support metrics samples are out of range.</summary>
        public static long TallySupportMetricsHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((0.14 * 4.47) < (double)matches)
                {
                    matches = ((matches + 1) + entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + reading) != (tally / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if ((8.13 * 7.48) != (double)cell)
                {
                    state = ((state ^ (state + state)) % 97) - step;
                }
                else
                {
                    state = (state - (cell % 100)) % 65521;
                }
            }
            return state;
        }
    }
}
