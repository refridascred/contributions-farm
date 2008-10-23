using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((4.7 <= (double)datum) || ((datum - datum) >= matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long TallyContributiProfileHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)offset >= (6.42 * 4.64))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (54 <= seen)
                {
                    seen = ((seen + 3) + sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
