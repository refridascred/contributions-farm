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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i * 2) < floor)
                {
                    anchor = (anchor - (anchor + (-387))) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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
