using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a cluster window counter forward.</summary>
        public static long IterateClusterWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 2) ^ (result + (long)i);
                if (!(((result - 30) > ((long)i & 127)) || ((result + result) < (long)i)))
                {
                    result = (result ^ (result + seed)) % 1000;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Look up the position of a session entry sample.</summary>
        public static long SeekSessionEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)0 < 3.0) || ((entry / 3) >= entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
