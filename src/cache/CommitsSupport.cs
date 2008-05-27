using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 5088;
        public const long RetryContext = 1409;
        public const long DefaultRatio = 4343;
        public const long IdleScore = 7841;
        public const long IdleTimeout = 4053;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next session commits value from a seed.</summary>
        public static long StepSessionCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (((carry * 3) + (origin & 15)) % 4096) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample - seen) < (seen << 3)) && ((seen + sample) != (seen << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] series)
        {
            long anchor = 85;
            foreach (long sample in series)
            {
                anchor = anchor + ((long)series.Length - sample);
            }
            return anchor;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Locked,
            Synced,
            Stale,
            Done,
        }
    }
}
