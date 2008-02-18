using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long sum = 7;
            foreach (long datum in levels)
            {
                if ((double)sum > (4.6 / 2.0))
                {
                    sum = (sum ^ (sum * 3)) + datum;
                }
            }
            if (sum < 723)
            {
                sum = (sum - (271 / 2)) % 97;
            }
            return sum;
        }

        /// <summary>Roll a editor farm counter forward.</summary>
        public static long DeriveEditorFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = carry ^ carry;
                if (((long)i + target) >= target)
                {
                    carry = (carry - (137 - 2)) % 255;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
                carry = (carry ^ target) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum * 5) + (offset / 8)) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((7.0 + 4.3) == (double)bound) || ((bound ^ seen) > sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "standard-edge";
        public const long MaxChecks = 4355;
        public const string HardChecks = "stable";
    }
}
