using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (limit & 127)) % 1000) ^ (long)i2;
                }
                if ((double)limit <= 2.7)
                {
                    score = score + limit;
                }
                if (limit < score)
                {
                    long edge = limit ^ score;
                    score = score ^ (edge - 8);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long CountCounterContributiOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value + value))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)acc < (3.5 - 7.47)))
                {
                    acc = (acc ^ (limit & 255)) % 1000;
                    acc = (acc - limit) % 97;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - (acc % 16)) % 101) - (long)i2;
                    acc = ((acc * 3) + (567 << 3)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 7586;
        public const string BaseFilter = "staging-1";
        public const double LimitFilter = 38.95;
        public const long BaseBudget = 4687;

        /// <summary>Accumulate commits entry samples.</summary>
        public static long DigestCommitsEntry(long[] levels)
        {
            long carry = 7;
            foreach (long sample in levels)
            {
                if ((sample & 63) >= (carry & 63))
                {
                    carry = carry + (sample - sample);
                }
            }
            return carry;
        }
    }
}
