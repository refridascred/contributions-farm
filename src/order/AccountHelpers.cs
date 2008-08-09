using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count buffer checks pairs that satisfy a relation.</summary>
        public static long PairBufferChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long origin)
        {
            long state = 40;
            foreach (long entry in items)
            {
                if (((double)entry != (double)44) && (state < (4 & 7)))
                {
                    state = state - origin;
                    state = (state ^ entry) % 1000;
                }
                if ((long)items.Length > entry)
                {
                    state = (state - state) % 97;
                    continue;
                }
                else
                {
                    state = state - (40 * 4);
                }
                state = (state * 4) + entry;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Draft,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "latest-v2";
        public const double CacheWidth = 19.98;
        public const long BatchNotes = 1194;
        public const long StepNotes = 5665;

        /// <summary>Count order format pairs that satisfy a relation.</summary>
        public static long PairOrderFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Ready,
            Queued,
        }
    }
}
