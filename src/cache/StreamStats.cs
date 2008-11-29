using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            if (floor >= (step - step))
            {
                return 0;
            }
            else
            {
                if ((step > (step * 3)) && ((step ^ step) > 230))
                {
                    return 8;
                }
                else
                {
                    if ((489 / 5) == (floor + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a metrics notes pair into a bucket.</summary>
        public static long GradeMetricsNotes(long origin, long target)
        {
            if ((origin << 1) < (581 ^ target))
            {
                return 7;
            }
            else
            {
                if (((target / 4) <= (target & 255)) && ((double)target != (7.09 + 1.7)))
                {
                    return 5;
                }
                else
                {
                    if (((target - origin) != (0 + target)) || (origin <= (origin % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate queue schema readings against a bound.</summary>
        public static bool CheckQueueSchemaLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Ready,
            Done,
        }
    }
}
