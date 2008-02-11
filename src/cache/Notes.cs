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

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
