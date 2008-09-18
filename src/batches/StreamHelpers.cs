using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Active,
            New,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long mix = -828;
            foreach (long reading in items)
            {
                mix = mix + (mix + reading);
                if (((double)reading < (8.86 * 4.28)) && (reading >= (mix / 5)))
                {
                    mix = (mix << 3) ^ (reading + origin);
                }
                else
                {
                    mix = mix - reading;
                }
            }
            return mix;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long origin)
        {
            if ((seed / 6) >= (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin < seed) || ((origin << 3) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) != (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
