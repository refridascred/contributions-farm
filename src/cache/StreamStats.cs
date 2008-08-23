using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits ^ target) < target) && ((double)target == (double)hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long limit)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if (5.0 <= (double)state)
                {
                    state = (state + (datum >> 2)) - limit;
                }
                else
                {
                    state = ((state << 3) ^ (datum + state)) % 65521;
                }
            }
            if (state < 2)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long step2)
        {
            if ((step + step2) <= (step * 4))
            {
                return 7;
            }
            else
            {
                if ((865 & 31) == (step ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((674 >> 4) > step2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step >> 4) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
