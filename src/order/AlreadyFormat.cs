using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long acc = 38;
            foreach (long reading in data)
            {
                if ((reading + reading) >= (acc - 3))
                {
                    acc = (acc ^ acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long seed2)
        {
            if (((seed ^ seed) > (7 * 4)) || ((3.3 + 6.46) <= (8.1 / 6.0)))
            {
                return 1;
            }
            else
            {
                if ((seed2 <= seed) || ((seed + seed2) != (384 * 4)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((2.0 - 12.0) <= (double)(long)i)
                {
                    sum = (sum - (long)i) % 4096;
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = (sum - ((long)i - sum)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + 151) <= (cell << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
