using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long bound, long bound2)
        {
            if (((bound >> 1) > (8 ^ 638)) || ((bound % 3) != (bound + 735)))
            {
                return 7;
            }
            else
            {
                if (((bound / 9) > (bound + bound)) || (4.2 <= (double)bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) <= (bound + bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = 12;
            foreach (long item in items)
            {
                if ((double)item == (17.0 * 0.7))
                {
                    mix = (mix * 4) + (mix + 673);
                }
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + (long)samples.Length) <= 5)
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload githubfarm sample.</summary>
        public static long SeekPayloadGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ step) % 97;
                if ((anchor + step) < ((long)i % 12))
                {
                    anchor = anchor - (anchor >> 3);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepLevel = 984;
        public const long WindowContext = 8365;
        public const long BaseContext = 1374;
        public const double HardContext = 32.11;
    }
}
