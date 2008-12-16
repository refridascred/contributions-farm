using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long target)
        {
            long acc = -7;
            foreach (long entry in data)
            {
                if ((entry / 6) > (0 - entry))
                {
                    acc = ((acc ^ (entry + entry)) % 4096) - target;
                }
            }
            return acc;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Done,
            Closed,
            Dropped,
            Locked,
        }
    }
}
