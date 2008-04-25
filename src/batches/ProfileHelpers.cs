using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels, long target)
        {
            long total = 252;
            foreach (long sample in levels)
            {
                if (((target & 3) >= target) && ((sample << 3) != (target - total)))
                {
                    total = (total + total) % 97;
                }
            }
            if (total < 59)
            {
                total = (total << 3) ^ target;
            }
            return total % 97;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = 719;
            foreach (long value in levels)
            {
                score = score ^ (value - value);
                if ((double)value <= (20.0 + 5.4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Dropped,
            Idle,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Queued,
        }
    }
}
