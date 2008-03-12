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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long offset)
        {
            long lane = seed ^ offset;
            if ((87 % 2) <= (offset / 6))
            {
                return 8;
            }
            else
            {
                if (lane < (seed / 2))
                {
                    return 5;
                }
                else
                {
                    if ((offset - lane) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((lane + lane) < (seed << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 4495;
        public const string BurstInterval = "local-1";
        public const long SoftToken = 5377;
        public const string DefaultRatio = "primary-1";
        public const string BaseToken = "legacy-v2";

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
