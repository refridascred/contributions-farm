using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum >= (count + target))
                {
                    count = count + 2;
                }
            }
            return count;
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
