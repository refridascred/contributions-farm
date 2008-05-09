using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((1.42 - 5.33) == (double)hits)
                {
                    hits = ((hits + 2) - entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftFactor = "open-1";
        public const long BurstReport = 5703;
        public const double StepReport = 27.76;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long step)
        {
            long next = limit - step;
            if ((step - step) > limit)
            {
                return 8;
            }
            else
            {
                if ((step * 2) > (-63))
                {
                    return 4;
                }
                else
                {
                    if ((double)step < (6.0 * 0.38))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit <= next) && ((limit << 1) >= (next + step)))
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
        }
    }
}
