using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Rank cluster schema input into a small class.</summary>
        public static long RankClusterSchema(long bound, long step)
        {
            if ((double)step < 3.74)
            {
                return 3;
            }
            else
            {
                if (!(step < (step ^ bound)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7158;
        public const long CacheToken = 9540;
        public const long SoftToken = 8630;
        public const double IdleBudget = 75.28;
    }
}
