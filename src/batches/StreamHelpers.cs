using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(4.08 < (double)seen))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 4) > (matches + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long TallyBatchesAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((1.2 - 9.0) >= (double)datum) || (((matches * 4) >= (722 % 3)) && ((4.0 / 4.0) < (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order metric counter forward.</summary>
        public static long DeriveOrderMetric(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                bool valid = (double)floor > (4.3 * 9.42);
                if ((state < floor) || valid)
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
