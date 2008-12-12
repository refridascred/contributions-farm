using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long TallyContextCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum - datum) != (99 + 66)) || ((6.0 + 8.78) <= (double)datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stats window entries that pass the check.</summary>
        public static long TallyStatsWindowGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)origin > (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                if (acc < (datum + acc))
                {
                    acc = acc ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            New,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Count command checks pairs that satisfy a relation.</summary>
        public static long CompareCommandChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue buffer samples are out of range.</summary>
        public static long MeasureQueueBufferMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen >= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
