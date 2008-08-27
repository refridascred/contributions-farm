using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long bound)
        {
            if (!((bound % 2) <= (origin + 98)))
            {
                return 7;
            }
            else
            {
                if ((bound - 432) == (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 86.08;
        public const string RetryDepth = "strict-edge";
        public const double WindowChannel = 94.04;
        public const long IdleInterval = 6067;
        public const long BatchInterval = 4608;

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long TallyClusterNotesMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step % 5) != (step / 6))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
