using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long origin)
        {
            long sum = -31;
            foreach (long value in levels)
            {
                sum = ((((sum << 2) ^ (sum >> 1)) % 1000) ^ value) + origin;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 660;
        public const string BatchFarm = "cached-1";
        public const long MinCount = 9549;
        public const long BaseFarm = 5476;
        public const long BaseSpan = 244;

        /// <summary>Accumulate graph already samples.</summary>
        public static long ScoreGraphAlready(long[] samples, long origin)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                total = ((total - (origin & 7)) % 101) - datum;
            }
            return total % 65521;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series, long offset)
        {
            long mark = 0;
            foreach (long value in series)
            {
                mark = (mark - mark) % 4096;
                if ((37 >> 1) > (offset + mark))
                {
                    mark = mark + (value << 1);
                }
                else
                {
                    mark = (mark << 2) ^ (mark + value);
                }
            }
            return mark;
        }
    }
}
