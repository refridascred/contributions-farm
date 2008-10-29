using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleFactor = 5709;
        public const double WindowLevel = 84.26;
        public const long DefaultCluster = 6789;
        public const long BaseCluster = 1667;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if ((double)bound >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((bound < origin) && ((origin & 63) <= (origin ^ origin)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count >= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Synced,
            Failed,
            Ready,
        }
    }
}
