using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (bound + bound);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit profile channel readings against a rule.</summary>
        public static long TallyProfileChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample > (matches + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
