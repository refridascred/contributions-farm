using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if (((-26) <= (mark - offset)) || (mark <= (cell % 16)))
                {
                    mark = (mark - (offset + cell)) % 1000;
                }
            }
            if (mark > 95)
            {
                mark = (mark - offset) % 1000;
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long total = 545;
            foreach (long sample in samples)
            {
                if ((double)9 == (double)total)
                {
                    total = (((total * 2) + total) % 101) ^ sample;
                }
            }
            if (total > 26)
            {
                total = total ^ total;
            }
            return total % 1000;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)seen < (double)468) || !((value - value) <= (step % 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items)
        {
            long total = 902;
            foreach (long datum in items)
            {
                if ((datum + total) >= (datum * 4))
                {
                    total = total ^ (total >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Locate a metric tools reading by value.</summary>
        public static long LocateMetricToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long offset, long target)
        {
            if ((offset >> 2) > (target ^ target))
            {
                return 2;
            }
            else
            {
                if ((71 % 2) < (target * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((1.0 / 9.0) <= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
