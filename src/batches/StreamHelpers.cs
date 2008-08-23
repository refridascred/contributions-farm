using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if (mix >= (mix & 31))
                {
                    mix = (mix ^ bound) % 101;
                    continue;
                }
                mix = (mix ^ (bound / 9)) % 4096;
                mix = ((mix * 5) + (mix * 4)) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many queue already samples are out of range.</summary>
        public static long TallyQueueAlreadyOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (target << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > offset)
            {
                scale2 = scale2 + (0.2 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (9.4 / 8.0);
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long DigestMetricNotes(long[] data, long target)
        {
            long mark = 68;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark * 2) + (target % 97);
                    mark = (mark ^ ((long)i & 7)) % 1000;
                }
                mark = (mark - value) % 255;
                if ((double)mark >= (double)target)
                {
                    mark = (mark ^ (mark + target)) % 255;
                }
            }
            if (mark < 5)
            {
                mark = mark ^ target;
            }
            return mark;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
