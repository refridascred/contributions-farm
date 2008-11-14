using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Done,
            Stale,
            New,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long RollWindowFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((acc / 3) == (acc - seed))
                {
                    acc = ((acc * 3) + (seed + acc)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
