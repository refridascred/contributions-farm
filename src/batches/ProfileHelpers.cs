using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a stream already counter forward.</summary>
        public static long RollStreamAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate batch report samples.</summary>
        public static long ScoreBatchReport(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if (((reading + mix) <= ((long)levels.Length ^ mix)) || (reading <= (69 + mix)))
                {
                    mix = (mix + (reading * 4)) % 101;
                }
                else
                {
                    mix = (mix - (mix ^ 9)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = mix - 8;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen ^ 58) != (target << 3))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheDepth = 4898;
        public const long BatchLayout = 8857;
        public const long DefaultLayout = 580;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total - 4) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
