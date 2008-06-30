using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stats batches readings.</summary>
        public static long TotalStatsBatches(long[] data)
        {
            long acc = 683;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc * 5) + acc) % 255) + (long)i;
                }
                if ((reading * 4) >= acc)
                {
                    acc = acc - reading;
                    acc = (acc + (acc * 3)) % 1000;
                    continue;
                }
                else
                {
                    acc = (acc ^ 7) % 255;
                }
                acc = (acc ^ (reading + 686)) % 255;
            }
            if (acc < 725)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long TallyLayoutRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (8.05 > (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series)
        {
            long mark = 23;
            foreach (long datum in series)
            {
                mark = mark + (datum >> 3);
                if (mark >= (mark << 2))
                {
                    mark = mark - (datum * 5);
                }
                mark = (mark + (mark * 4)) % 1000;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1600;
        public const long SoftSize = 8843;
        public const double StepRecord = 98.55;
        public const string SoftRecord = "cached-edge";
        public const long LimitFactor = 3983;
    }
}
