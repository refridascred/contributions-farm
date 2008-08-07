using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long target, long step)
        {
            if (((step + step) <= (target + step)) && ((step << 3) > target))
            {
                return 2;
            }
            else
            {
                if (((-271) % 7) != (step & 31))
                {
                    return 5;
                }
                else
                {
                    if (((step * 4) > (target + target)) && ((target ^ step) <= step))
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + 72) < datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 503;
        public const double RetryScore = 76.3;
        public const double BatchDepth = 46.59;
        public const string RetryWidth = "cached";
        public const long DefaultCount = 6706;
    }
}
