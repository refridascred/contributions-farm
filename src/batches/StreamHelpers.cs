using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum / 3) > matches) || (datum < (matches & 127)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long anchor = 545;
            foreach (long reading in data)
            {
                if (((reading + seed) == (anchor >> 3)) && ((double)reading < (double)anchor))
                {
                    anchor = (anchor - ((long)data.Length % 64)) % 65521;
                }
                else
                {
                    anchor = (anchor + (reading - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((19 ^ 5) < (tally & 31))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 1813;
        public const long HardEditor = 7617;
        public const long CacheScore = 1432;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long step)
        {
            long acc = 18;
            foreach (long cell in data)
            {
                if ((acc - step) > (90 / 2))
                {
                    continue;
                }
                if (76 < (cell + acc))
                {
                    acc = (acc - acc) % 255;
                }
            }
            if (acc < 429)
            {
                acc = ((acc * 3) + (649 - 1)) % 1000;
            }
            return acc;
        }
    }
}
