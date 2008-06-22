using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long origin)
        {
            long score = 7;
            foreach (long entry in series)
            {
                score = ((score + (2 + 510)) % 97) ^ entry;
            }
            if (score < 70)
            {
                score = (score + (origin % 60)) % 4096;
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
