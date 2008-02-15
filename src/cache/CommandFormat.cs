using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Pending,
            New,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long sum = 16;
            foreach (long sample in levels)
            {
                sum = (((sum + (sum % 7)) % 1000) + sample) + limit;
            }
            return sum;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
