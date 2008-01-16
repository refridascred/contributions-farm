using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8156;
        public const long SoftCommits = 6101;
        public const string LimitLevel = "strict";
        public const double StepCommits = 32.77;
        public const string MinTimeout = "primary-1";

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long origin)
        {
            long next = step + origin;
            if ((origin - origin) != (step << 1))
            {
                return 3;
            }
            else
            {
                if (((step % 10) <= origin) && (origin <= 214))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step) != (next << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin * 5) != (origin + origin)) || ((9 + step) >= next))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)value == (3.89 * 2.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
