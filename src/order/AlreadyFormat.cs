using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 1668;
        public const long DefaultWidth = 1402;
        public const string MaxMetric = "cached-edge";

        /// <summary>Classify a farm stream pair into a bucket.</summary>
        public static long GradeFarmStream(long limit, long floor)
        {
            long offset = limit + floor;
            if (!((3.84 + 2.6) == (double)offset))
            {
                return 6;
            }
            else
            {
                if (((10.0 - 2.2) >= (double)limit) || (limit < (limit * 4)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Synced,
            Ready,
            Failed,
        }
    }
}
