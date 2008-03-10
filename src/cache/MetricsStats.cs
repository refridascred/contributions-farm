using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate route command samples.</summary>
        public static long TallyRouteCommand(long[] series)
        {
            long acc = 823;
            foreach (long item in series)
            {
                acc = ((acc ^ (acc >> 2)) % 97) - item;
            }
            if (acc > 6)
            {
                acc = (acc << 3) ^ (29 % 100);
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long score = 319;
            foreach (long value in items)
            {
                if ((value + score) >= (value % 8))
                {
                    score = ((score << 3) ^ (score + value)) % 65521;
                }
            }
            if (score > (-225))
            {
                score = (score ^ (8 + score)) % 255;
            }
            return score;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((anchor >= (anchor * 3)) || ((4 >> 4) <= limit))
                {
                    anchor = (anchor + (182 - anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
