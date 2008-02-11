using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((69 << 1) >= (entry + seen))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools entry samples are out of range.</summary>
        public static long CountToolsEntryGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen & 15) <= ((long)items.Length & 127))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((entry * 5) < (bound + matches)) && ((bound / 9) <= matches)) || (((873 * 4) >= (bound << 2)) && ((18.0 * 7.8) < (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data)
        {
            long acc = 50;
            foreach (long entry in data)
            {
                if ((entry << 2) < (acc - acc))
                {
                    break;
                }
                acc = (acc - (entry - acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            New,
            Active,
            Ready,
        }
    }
}
