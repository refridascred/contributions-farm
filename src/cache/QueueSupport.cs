using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(482 > matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Paused,
            Ready,
            New,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] items)
        {
            long sum = 86;
            foreach (long reading in items)
            {
                if ((reading & 63) >= reading)
                {
                    sum = (sum << 2) ^ ((long)items.Length + sum);
                }
                else
                {
                    sum = sum ^ (sum + 65);
                }
            }
            return sum;
        }
    }
}
