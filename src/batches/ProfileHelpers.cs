using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((floor % 64) >= 456)
                {
                    tally = (tally + 3) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                long bound2 = (state / 8) + state;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 3) ^ bound2) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((555 + entry) < (origin + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7605;
        public const string IdleEditor = "open";
        public const string BaseFactor = "primary-1";
        public const string BaseEditor = "cached";
    }
}
