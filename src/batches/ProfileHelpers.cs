using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of support schema readings.</summary>
        public static long TotalSupportSchema(long[] readings)
        {
            long total = 115;
            foreach (long sample in readings)
            {
                if (total > (sample << 3))
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = ((total * 2) + total) % 4096;
                }
            }
            if (total < (-9))
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Classify a token stats pair into a bucket.</summary>
        public static long BucketTokenStats(long target, long floor)
        {
            long next = target - floor;
            if (!(next <= (target + 2)))
            {
                return 5;
            }
            else
            {
                if (((next + floor) >= floor) || ((1 + floor) <= (next & 255)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 8010;
        public const string SoftSession = "local";
        public const long LimitSession = 4450;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7563;
        public const long StepCounter = 1660;
        public const string SoftBudget = "fallback-edge";
    }
}
