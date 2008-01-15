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

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 18.91;
        public const long CacheDepth = 1072;
        public const string MinCommand = "open-edge";
        public const double SoftScore = 38.8;
        public const double RetryInterval = 19.88;
    }
}
