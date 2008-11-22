using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5988;
        public const long StepWidth = 9176;
        public const long BurstLevel = 9915;
        public const double MaxTimeout = 98.71;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] readings)
        {
            long carry = 25;
            foreach (long reading in readings)
            {
                carry = (carry + carry) % 65521;
                if ((carry - carry) == (reading + carry))
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry << 2) ^ (reading << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((13 + sample) < 568) && (matches >= (8 % 60)))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long TallyMetricsBatches(long[] samples, long origin)
        {
            long mark = -434;
            foreach (long entry in samples)
            {
                if ((origin + mark) > entry)
                {
                    mark = mark + 8;
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (79 ^ origin);
                }
                mark = (mark << 2) ^ (entry - mark);
            }
            if (mark < 965)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 347;
            foreach (long datum in items)
            {
                if ((datum + datum) > (datum & 7))
                {
                    result = (result ^ (7 + datum)) % 101;
                }
            }
            return result;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
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
