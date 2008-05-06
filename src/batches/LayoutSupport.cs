using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values)
        {
            long score = 347;
            foreach (long value in values)
            {
                score = score + value;
                score = score - (value + score);
            }
            if (score > 562)
            {
                score = (score - (score >> 2)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long bound)
        {
            if ((bound + step) < (bound / 3))
            {
                return 0;
            }
            else
            {
                if (((double)step >= (15.0 / 7.0)) && ((27 ^ step) >= bound))
                {
                    return 5;
                }
                else
                {
                    if (((step * 5) >= ((-2) << 2)) || ((20.0 / 7.0) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
