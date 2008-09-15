using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long limit)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                result = (((result ^ ((long)levels.Length % 12)) % 101) - datum) - limit;
            }
            return result;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate payload editor samples.</summary>
        public static long ScorePayloadEditor(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                if ((sample - mark) < (sample + sample))
                {
                    mark = (mark ^ (sample * 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7799;
        public const double MinNotes = 16.47;
        public const long MaxScore = 7897;
    }
}
