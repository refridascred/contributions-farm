using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9021;
        public const long DefaultGithubfarm = 3223;
        public const long BaseLevel = 6843;

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum + tally) > 485) && ((datum - datum) >= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] values, long origin)
        {
            long acc = 0;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = acc ^ (origin % 3);
                    acc = (acc * 4) + ((long)i - acc);
                }
                if ((acc << 2) < (origin - acc))
                {
                    acc = (acc ^ acc) % 4096;
                }
                else
                {
                    acc = acc - (value & 127);
                }
            }
            return acc;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < (5.37 * 3.0)) || (((double)cell >= (15.0 - 5.6)) && ((978 - 8) != (cell >> 4))))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
