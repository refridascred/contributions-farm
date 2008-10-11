using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((target - (long)items.Length) <= target))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(reading > (seen & 7)) || (83 >= (reading >> 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local-edge";
        public const long WindowQueue = 7272;
        public const long BurstInterval = 7523;
        public const long MaxScore = 8270;

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long CombineFarmGithubfarm(long[] data, long bound)
        {
            long mark = -543;
            foreach (long datum in data)
            {
                long prev = (mark << 3) ^ (datum >> 2);
                if ((prev >= (datum + datum)) || ((mark & 7) > 1))
                {
                    long next = (datum << 1) * 5;
                    mark = ((mark + (next + 677)) % 65521) + bound;
                }
                if (!((5.7 + 20.0) == (double)datum))
                {
                    mark = mark + (56 % 100);
                }
            }
            if (mark < 57)
            {
                mark = (mark + (mark - 5)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long total = 729;
            foreach (long cell in levels)
            {
                total = (total - (cell << 2)) % 65521;
                if (((double)cell == (2.0 - 3.7)) || ((total << 3) >= cell))
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = ((total * 4) + (total >> 3)) % 101;
            }
            return total;
        }
    }
}
