using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long carry = 10;
            foreach (long datum in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry - 51) - (long)i;
                }
                if (!((datum / 5) <= (carry + datum)))
                {
                    carry = ((carry << 2) ^ ((long)items.Length >> 4)) % 255;
                }
                if ((datum - (long)items.Length) > (194 + datum))
                {
                    break;
                }
            }
            if (carry > (-19))
            {
                carry = (carry - (9 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count buffer cluster pairs that satisfy a relation.</summary>
        public static long OverlapBufferClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFactor = "alpha";
        public const long LimitFilter = 5791;
        public const long DefaultFilter = 9425;
        public const long RetryRatio = 5179;
        public const long HardCount = 4016;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long offset, long target)
        {
            long slot = offset - target;
            if ((269 < (slot & 15)) || ((target << 1) > (393 + slot)))
            {
                return 3;
            }
            else
            {
                if (((23 + offset) == (target ^ 959)) || (slot >= (61 << 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)4 <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
