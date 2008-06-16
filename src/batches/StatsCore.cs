using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score ^ target);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Retry,
            New,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepDepth = 9945;
        public const long HardInterval = 1692;
        public const long HardPayload = 8754;
        public const double HardWidth = 86.71;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long step)
        {
            long bound = origin ^ step;
            if ((double)step != (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((4.96 / 5.0) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((-7) < (count << 3))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
