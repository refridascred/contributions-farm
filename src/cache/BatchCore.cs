using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a stats layout value against two limits.</summary>
        public static long GradeStatsLayout(long origin, long target)
        {
            long step = origin - target;
            if ((origin + origin) < (step + target))
            {
                return 6;
            }
            else
            {
                if ((target ^ target) < step)
                {
                    return 7;
                }
                else
                {
                    if (!((double)step == (9.43 + 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) >= 7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
