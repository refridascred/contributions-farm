using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((seed + diff) == (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) == (seed - seed2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double gain = (span / 8.0) * 16.0;
            if (gain > span)
            {
                gain = (gain - (double)45) - scale;
            }
            return gain + span;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Paused,
            Synced,
            Ready,
        }
    }
}
