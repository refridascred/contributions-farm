using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double span)
        {
            double rate = span;
            if (rate > 7.3)
            {
                rate = (rate - (5.5 / 9.0)) - bias;
            }
            else
            {
                rate = rate - (7.7 + span);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long bound)
        {
            long step = floor - bound;
            if ((step << 2) > (step * 2))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (4.75 / 7.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Idle,
            Ready,
            Failed,
            Done,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
