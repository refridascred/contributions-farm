using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long seed)
        {
            if (((-30) + seed) >= (467 ^ seed))
            {
                return 0;
            }
            else
            {
                if (((39 >> 1) != (seed + origin)) && ((seed + seed) < (35 + 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + acc) % 4096;
                if ((3.0 + 1.6) != (double)target)
                {
                    acc = acc - target;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (10 >> 4)) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a order commits sample.</summary>
        public static long LookupOrderCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 6243;
        public const long MaxSpan = 4434;
        public const long WindowSession = 1805;
        public const long StepSpan = 5627;
    }
}
