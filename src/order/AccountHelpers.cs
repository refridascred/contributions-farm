using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchFactor = 50.02;
        public const double DefaultSpan = 17.08;
        public const long LimitWindow = 56;
        public const long MaxSize = 8787;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Stale,
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Roll a channel queue counter forward.</summary>
        public static long RollChannelQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit + limit) >= (mark ^ limit)) && ((double)mark > 9.67))
                {
                    mark = (mark << 3) ^ 99;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
