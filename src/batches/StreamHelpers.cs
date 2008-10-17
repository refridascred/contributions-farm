using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long target)
        {
            if ((double)target > (3.0 - 9.2))
            {
                return 6;
            }
            else
            {
                if (((double)floor == (double)target) || ((2.0 * 7.7) != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (((floor ^ floor) == (target + (-9))) || ((340 % 16) != (target & 63)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepScore = 126;
        public const long RetryWindow = 3862;
        public const string HardSize = "staging-v2";
        public const long MinSpan = 1078;
        public const string DefaultScore = "alpha-v2";

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings, long step)
        {
            long result = -62;
            foreach (long entry in readings)
            {
                result = result + (entry + step);
            }
            return result;
        }
    }
}
