using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((bound * 3) >= (3 + bound))
                {
                    anchor = anchor + (bound ^ bound);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (!((bound3 >> 4) > (bound3 * 2)))
            {
                return 8;
            }
            else
            {
                if (bound2 <= (32 + bound2))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 5) != (81 / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound3 + 108) < (bound - bound)) && ((95 >> 5) == (bound3 / 9)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route schema values into a single score.</summary>
        public static long CombineRouteSchema(long[] samples)
        {
            long state = 556;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (8 / 9)) % 255) + (long)i;
                }
                if ((state / 8) == (state >> 3))
                {
                    state = ((state << 3) ^ reading) % 255;
                }
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + step) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry + 87) <= (seen / 7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Retry,
            Pending,
        }
    }
}
