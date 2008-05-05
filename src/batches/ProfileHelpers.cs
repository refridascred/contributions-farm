using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine queue stats values into a single score.</summary>
        public static long FoldQueueStats(long[] items, long floor)
        {
            long state = 847;
            foreach (long cell in items)
            {
                state = ((state ^ (long)items.Length) % 97) ^ cell;
                if (382 > (floor + (long)items.Length))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + 6) == (88 ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long acc = 55;
            foreach (long value in data)
            {
                acc = (((acc * 4) + (acc >> 4)) % 101) ^ value;
                if ((double)acc <= (2.44 / 3.0))
                {
                    acc = (acc ^ (acc * 3)) % 101;
                }
            }
            return acc;
        }
    }
}
