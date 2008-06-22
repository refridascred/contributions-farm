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

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long sum = 797;
            foreach (long reading in levels)
            {
                if (!((reading & 7) <= (reading ^ reading)))
                {
                    sum = (sum + (sum + reading)) % 255;
                }
            }
            if (sum > 23)
            {
                sum = (sum ^ (298 & 31)) % 65521;
            }
            return sum;
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
