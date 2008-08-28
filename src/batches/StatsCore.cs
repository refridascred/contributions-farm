using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry ^ (37 / 7)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = (((mix * 4) + (mix & 31)) % 255) + sample;
            }
            return mix;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long MatchProfileCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Pending,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Active,
            Pending,
            Dropped,
        }
    }
}
