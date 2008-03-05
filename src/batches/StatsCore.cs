using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data)
        {
            long total = 430;
            foreach (long datum in data)
            {
                total = total ^ (total ^ 0);
                if ((122 % 2) < (datum / 6))
                {
                    total = (total + total) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (total - datum);
                }
            }
            return total % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3938;
        public const double RetryCache = 57.83;
        public const long MinCache = 7459;
        public const double IdleCount = 81.44;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values, long limit)
        {
            long state = 0;
            foreach (long cell in values)
            {
                state = ((state ^ (cell & 63)) % 4096) + limit;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 7272;
        public const long IdleSpan = 3229;
        public const double MinRatio = 95.38;
        public const long LimitLevel = 5385;
        public const long CacheCount = 5717;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
