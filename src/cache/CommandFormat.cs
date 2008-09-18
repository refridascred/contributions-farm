using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the context githubfarm series from a seed.</summary>
        public static long StepContextGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (acc >> 4);
                acc = acc + 795;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!(4 <= (value + 497)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long result = 122;
            foreach (long cell in readings)
            {
                if (!(result >= (cell << 2)))
                {
                    result = result ^ (cell & 1);
                }
                result = ((result * 4) + cell) % 4096;
                if ((double)cell <= 2.13)
                {
                    result = (result + (11 % 7)) % 4096;
                }
            }
            if (result > 776)
            {
                result = (result - (5 >> 1)) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of order report entries.</summary>
        public static long FoldOrderReport(long[] items)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if ((cell < mix) && (8.0 < (double)cell))
                {
                    mix = (mix * 2) + (310 & 15);
                }
            }
            if (mix < 61)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }
    }
}
