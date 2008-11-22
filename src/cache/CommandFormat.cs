using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 7423;
        public const string IdleBudget = "strict-edge";
        public const string BatchMetric = "strict-v2";
        public const double StepMetric = 44.31;
        public const string HardCount = "staging-1";

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items, long limit)
        {
            long anchor = -59;
            foreach (long reading in items)
            {
                anchor = (((anchor ^ ((long)items.Length - anchor)) % 97) - reading) - limit;
            }
            if (anchor < 42)
            {
                anchor = (anchor + (anchor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long bound)
        {
            long cur = step + bound;
            if ((45 ^ step) == (bound - step))
            {
                return 7;
            }
            else
            {
                if ((double)cur <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step % 64) > (cur << 3))
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
    }
}
