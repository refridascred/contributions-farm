using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 4.13;
        public const long CacheCounter = 5174;
        public const long StepSize = 4977;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples, long target)
        {
            long mark = 24;
            foreach (long value in samples)
            {
                if ((7.1 + 2.6) == (double)(long)samples.Length)
                {
                    mark = (mark - (-704)) + value;
                }
            }
            if (mark < 74)
            {
                mark = mark + (target >> 1);
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((14.0 * 0.66) < (double)bound)
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
