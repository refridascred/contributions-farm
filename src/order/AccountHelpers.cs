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

        /// <summary>Count batch window pairs that satisfy a relation.</summary>
        public static long CompareBatchWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
