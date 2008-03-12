using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a contributi window counter forward.</summary>
        public static long SeriesContributiWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5263;
        public const string RetryCommits = "strict";
        public const long MinRatio = 5340;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool VerifyEntryToolsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long floor)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = sum + (sum << 2);
                if ((double)floor >= (double)480)
                {
                    sum = (sum + (151 - sum)) % 1000;
                }
                else
                {
                    sum = (sum * 3) + cell;
                }
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((4.1 + 7.35) > (6.87 - 4.28))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
