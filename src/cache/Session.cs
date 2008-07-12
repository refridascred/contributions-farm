using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long step)
        {
            if ((889 / 8) >= (step + offset))
            {
                return 2;
            }
            else
            {
                if ((offset <= (offset + offset)) && ((step % 2) != (offset + offset)))
                {
                    return 7;
                }
                else
                {
                    if ((step ^ 75) > (step - 40))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)35 == (double)step) && ((offset >> 3) < (340 % 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen / 6) == (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((entry % 8) >= (249 + 204))
                {
                    state = state + (entry + state);
                }
            }
            return state;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] series)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if ((acc / 2) == (entry - acc))
                {
                    acc = ((acc * 2) + (50 + entry)) % 101;
                }
            }
            if (acc > 223)
            {
                acc = acc + acc;
            }
            return acc;
        }
    }
}
