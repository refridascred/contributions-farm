using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - (score - origin)) % 4096) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data, long limit)
        {
            long score = 93;
            foreach (long entry in data)
            {
                score = ((score ^ (limit ^ limit)) % 97) ^ entry;
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches < (matches >> 4)) || ((1 ^ matches) < reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            New,
            Draft,
            Active,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
