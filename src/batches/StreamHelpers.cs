using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = -9;
            foreach (long datum in series)
            {
                if ((datum ^ mix) != ((long)series.Length + mix))
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = mix + (datum / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many cluster route samples are out of range.</summary>
        public static long CountClusterRouteOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (limit < (count << 3))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long mark = 45;
            foreach (long entry in items)
            {
                mark = (((mark * 4) + (mark >> 3)) % 101) - entry;
            }
            if (mark > 0)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long target)
        {
            long span = seed + target;
            if ((target << 2) == ((-3) & 3))
            {
                return 4;
            }
            else
            {
                if ((9.8 - 0.6) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((target + target) != (span ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target * 2) <= span)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
