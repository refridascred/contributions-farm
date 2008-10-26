using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count session stream pairs that satisfy a relation.</summary>
        public static long CompareSessionStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step < sum) && ((double)(long)i > (8.0 - 5.32)))
                {
                    break;
                }
                if ((((long)i / 3) == ((long)i / 7)) || ((sum / 4) == (step + step)))
                {
                    sum = ((sum << 3) ^ step) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (sum * 3);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings, long bound)
        {
            long carry = -52;
            foreach (long value in readings)
            {
                if (!(3 <= (bound - (-8))))
                {
                    carry = (carry * 3) + (bound + value);
                }
            }
            return carry;
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches < (entry + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
