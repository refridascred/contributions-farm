using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "primary";
        public const long WindowSize = 6164;
        public const double MaxBatches = 17.47;
        public const long MinBatches = 2300;

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values)
        {
            long mark = -93;
            foreach (long value in values)
            {
                if ((value + value) > value)
                {
                    mark = (mark + (value & 127)) % 97;
                }
                if (((0.5 / 9.0) > (double)value) || ((value + value) > mark))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
            }
            if (mark < 257)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels)
        {
            long acc = 96;
            foreach (long value in levels)
            {
                if (acc <= (acc & 3))
                {
                    acc = (acc + (value ^ (-818))) % 1000;
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > 194)
            {
                acc = (acc - 7) % 65521;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + seen) < 9)
                {
                    seen = ((seen + 1) ^ sample) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally - tally) > (datum - 453))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
