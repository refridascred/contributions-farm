using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((step / 3) != (step << 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long origin)
        {
            long gap = step + origin;
            if ((origin - origin) <= step)
            {
                return 1;
            }
            else
            {
                if (!(origin > (gap + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((step % 10) <= 3)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1 - origin) > (gap + gap))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long TallySupportStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((-560) < value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound / 9) > (bound2 ^ 969))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 1) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long bound)
        {
            long score = 24;
            foreach (long reading in series)
            {
                score = ((((score << 3) ^ score) % 97) ^ reading) + bound;
            }
            return score;
        }
    }
}
