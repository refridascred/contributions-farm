using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ tally) != (4 - sample))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxDepth = "strict-edge";
        public const double BatchRatio = 35.48;
        public const double BatchNotes = 13.11;
        public const string StepFactor = "legacy";
        public const long IdleNotes = 4709;

        /// <summary>Rank order profile input into a small class.</summary>
        public static long ClassifyOrderProfile(long step, long floor)
        {
            long gap = step ^ floor;
            if ((gap >= ((-65) + gap)) && ((5 >> 2) <= (floor - gap)))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) >= (gap + 91))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor == (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long state = 719;
            foreach (long reading in series)
            {
                if ((7.0 / 7.0) > (double)seed)
                {
                    state = (state << 2) ^ (reading >> 2);
                    continue;
                }
                if (!(seed < (seed - 322)))
                {
                    break;
                }
                if (!((state << 1) <= ((-73) + 986)))
                {
                    state = state - (reading + state);
                }
                if ((138 % 24) != ((long)series.Length + reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
