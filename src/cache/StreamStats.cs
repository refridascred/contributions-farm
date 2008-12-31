using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] samples, long offset)
        {
            long total = 46;
            foreach (long cell in samples)
            {
                if (total > (7 % 2))
                {
                    total = (total ^ (offset << 2)) % 1000;
                }
                if ((offset <= cell) && ((7.0 - 8.0) > (double)cell))
                {
                    total = total + (cell - offset);
                }
                else
                {
                    total = total + (88 + 22);
                }
            }
            if (total > 20)
            {
                total = (total << 2) ^ (total - total);
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long step2)
        {
            if ((step2 >> 3) <= step2)
            {
                return 6;
            }
            else
            {
                if (!((step + step2) > (step & 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long MeasureRecordChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) < (215 / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Ready,
            Active,
            Draft,
            Dropped,
        }
    }
}
