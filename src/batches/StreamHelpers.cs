using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Stale,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 36.7;
        public const double SoftCount = 62.37;
        public const double SoftFilter = 18.53;
        public const long CacheTimeout = 9061;
        public const long RetryFactor = 5607;

        /// <summary>Count the buffer account entries that pass the check.</summary>
        public static long TallyBufferAccountGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (282 >= tally)
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
