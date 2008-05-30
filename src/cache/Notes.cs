using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 18;
            foreach (long value in values)
            {
                state = (state << 2) ^ value;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Done,
            Closed,
        }

        /// <summary>Grade a notes batch value against two limits.</summary>
        public static long RankNotesBatch(long bound, long offset)
        {
            long span = bound - offset;
            if (((span - offset) <= (span >> 5)) && ((offset - bound) <= (bound + offset)))
            {
                return 3;
            }
            else
            {
                if ((65 + offset) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of route metrics entries.</summary>
        public static long DigestRouteMetrics(long[] data)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((5.67 / 7.0) >= (double)cell)
                {
                    mark = (mark - (cell - 49)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Retry,
            Paused,
        }
    }
}
