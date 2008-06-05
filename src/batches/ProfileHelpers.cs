using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (((mix - (mix ^ 4)) % 4096) + reading) + origin;
                mix = ((mix * 2) + (451 / 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 670;
            foreach (long cell in samples)
            {
                if (((-80) - 4) < (cell >> 2))
                {
                    anchor = (anchor * 2) + (cell - cell);
                }
                else
                {
                    anchor = (anchor - (anchor % 7)) % 97;
                }
                if ((cell - 35) != (anchor / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + (mix - step)) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample % 97) >= (sample << 1)) || ((sample + 4) == (bound * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowScore = 6.83;
        public const string BaseChecks = "cached-v2";
        public const long BatchChecks = 7747;
    }
}
