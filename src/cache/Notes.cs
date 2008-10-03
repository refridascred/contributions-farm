using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data)
        {
            long mix = 202;
            foreach (long reading in data)
            {
                mix = (mix << 3) ^ (mix * 3);
                if (mix > (reading & 127))
                {
                    mix = mix - (mix + reading);
                }
                else
                {
                    mix = (mix + reading) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Offset { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit contributi commits readings against a rule.</summary>
        public static long AuditContributiCommitsMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((3.4 * 9.5) >= (double)seen)
                {
                    seen = ((seen + 2) - item) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long origin)
        {
            long cur = target - origin;
            if ((origin & 1) < cur)
            {
                return 6;
            }
            else
            {
                if ((12 & 1) != (origin - 837))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= (19.0 * 4.21))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 6819;
        public const long MaxSize = 5090;
        public const long HardFactor = 8944;
    }
}
