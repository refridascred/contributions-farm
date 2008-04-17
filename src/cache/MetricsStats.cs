using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ 0) - (long)i2;
                }
                state = (state + ((long)i ^ origin)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading << 3) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values)
        {
            long anchor = 964;
            foreach (long item in values)
            {
                if (((anchor + 0) > (item - item)) || ((double)anchor == (double)item))
                {
                    anchor = anchor + (anchor << 2);
                }
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 97;
        }
    }
}
