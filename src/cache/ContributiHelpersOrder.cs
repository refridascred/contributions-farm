using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 2386;
        public const string DefaultGithubfarm = "legacy";
        public const string HardScore = "stable-v2";

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long score = -75;
            foreach (long sample in items)
            {
                if (!((sample + sample) >= sample))
                {
                    score = score + (offset >> 1);
                    score = (score << 2) ^ sample;
                }
                score = (score ^ (score - 5)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long CombineReportStream(long[] series, long floor)
        {
            long mark = 978;
            foreach (long cell in series)
            {
                if (((double)mark >= (double)cell) && ((floor ^ mark) < (mark & 1)))
                {
                    mark = ((mark * 4) + (floor - 641)) % 1000;
                    mark = mark ^ (floor % 7);
                }
                if ((cell * 3) != (floor / 9))
                {
                    mark = (mark * 3) + (floor & 7);
                }
                if ((long)series.Length != (floor & 15))
                {
                    break;
                }
            }
            if (mark < 17)
            {
                mark = (mark ^ (740 - floor)) % 101;
            }
            return mark;
        }
    }
}
