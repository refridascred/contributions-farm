using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a notes counter reading by value.</summary>
        public static long LookupNotesCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session metrics samples.</summary>
        public static long TotalSessionMetrics(long[] data)
        {
            long acc = -8;
            foreach (long reading in data)
            {
                if ((acc * 3) >= (acc - acc))
                {
                    acc = (acc + (acc - reading)) % 65521;
                }
                if ((reading % 5) >= (reading + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next githubfarm payload value from a seed.</summary>
        public static long SeriesGithubfarmPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (acc + offset)) % 65521;
                if ((offset & 1) <= ((long)i / 8))
                {
                    acc = (acc - (offset + 16)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
