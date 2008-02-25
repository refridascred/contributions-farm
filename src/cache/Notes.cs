using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if ((limit - limit) > (seed & 15))
            {
                return 3;
            }
            else
            {
                if (seed <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Locked,
            Pending,
            Paused,
            New,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Done,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long origin)
        {
            if ((75 - 1) > origin)
            {
                return 1;
            }
            else
            {
                if ((origin ^ offset) < (1 * 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                if ((result & 255) < (reading % 24))
                {
                    result = (result + result) % 101;
                }
                else
                {
                    result = (result << 3) ^ reading;
                }
            }
            return result;
        }
    }
}
