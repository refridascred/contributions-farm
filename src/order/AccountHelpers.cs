using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "local-edge";
        public const long DefaultWidth = 7834;
        public const double CacheGraph = 62.04;
        public const long IdleGraph = 9812;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i >= (8.22 * 6.5)) && (68 >= ((long)i + mark)))
                {
                    mark = (mark ^ ((long)i * 5)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long limit)
        {
            long carry = -2;
            foreach (long value in data)
            {
                carry = ((((carry * 4) + (0 * 4)) % 255) ^ value) + limit;
            }
            return carry % 97;
        }
    }
}
