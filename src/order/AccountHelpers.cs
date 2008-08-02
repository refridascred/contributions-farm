using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the notes session entries that pass the check.</summary>
        public static long MeasureNotesSessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits + 340) < value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + offset) <= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
