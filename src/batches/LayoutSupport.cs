using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Stale,
            Queued,
            Ready,
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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
