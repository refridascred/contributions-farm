using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ origin) % 101;
                score = ((score << 3) ^ (long)i) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell + seen) == (seen / 7)) || (cell > (seen / 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Pending,
            Queued,
            Idle,
        }
    }
}
