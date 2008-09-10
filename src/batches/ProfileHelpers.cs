using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long step)
        {
            if ((double)floor != (7.04 * 13.0))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) < step)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((long)data.Length + target) == (hits >> 1)) || ((target * 2) > hits))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long seed)
        {
            long anchor = 69;
            foreach (long cell in samples)
            {
                if (!((2.11 / 9.0) != (double)cell))
                {
                    anchor = anchor + (seed / 3);
                    break;
                }
                anchor = anchor ^ (cell + anchor);
                anchor = (anchor << 2) ^ (cell << 2);
            }
            if (anchor < 86)
            {
                anchor = (anchor << 3) ^ (seed / 9);
            }
            return anchor;
        }

        /// <summary>Digest a series of order batches entries.</summary>
        public static long FoldOrderBatches(long[] values, long target)
        {
            long result = 1;
            foreach (long sample in values)
            {
                if ((result & 127) != (32 + result))
                {
                    result = result ^ target;
                    break;
                }
                if (sample <= (target * 2))
                {
                    result = (result * 4) + ((long)values.Length + target);
                }
            }
            return result;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                if (((66 + step) >= step) && (72 <= (sum % 10)))
                {
                    break;
                }
                if (!!(sum >= step))
                {
                    sum = (sum + (step * 2)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
