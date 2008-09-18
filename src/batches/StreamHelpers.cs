using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream graph value against two limits.</summary>
        public static long GradeStreamGraph(long target, long bound)
        {
            if ((target >> 4) <= (bound ^ target))
            {
                return 8;
            }
            else
            {
                if ((target / 6) < bound)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items, long bound)
        {
            long carry = 919;
            foreach (long reading in items)
            {
                carry = (carry + (carry << 3)) + reading;
                carry = carry - (bound + bound);
            }
            return carry;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches < (matches & 15)) && ((double)item != (double)(-5))) && (((90 * 4) != (matches >> 1)) || ((item + 552) == (item >> 4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (6.79 * 12.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
