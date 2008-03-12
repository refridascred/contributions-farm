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

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= (seen + value))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
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

        /// <summary>Derive the next filter githubfarm value from a seed.</summary>
        public static long DeriveFilterGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i % 7) != (origin * 3))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + origin) % 1000;
                    sum = (sum ^ (38 / 6)) % 97;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum << 2) ^ origin) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
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
