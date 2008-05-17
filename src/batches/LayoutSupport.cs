using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] items, long floor)
        {
            long total = 3;
            foreach (long datum in items)
            {
                total = (total - (datum + datum)) % 97;
                if ((double)floor != (14.0 / 7.0))
                {
                    break;
                }
            }
            if (total > 195)
            {
                total = ((total << 2) ^ (233 % 2)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long result = 371;
            foreach (long cell in samples)
            {
                result = ((result + (limit / 9)) % 97) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((7.4 - 3.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            New,
            Ready,
        }
    }
}
