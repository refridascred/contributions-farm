using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 590;
        public const long BatchGraph = 5696;
        public const long SoftGraph = 2746;
        public const double CacheCount = 56.6;

        /// <summary>Grade a schema graph value against two limits.</summary>
        public static long BucketSchemaGraph(long target, long floor)
        {
            long prev = target - floor;
            if ((target & 255) == (prev * 5))
            {
                return 6;
            }
            else
            {
                if (target < (-143))
                {
                    return 5;
                }
                else
                {
                    if ((floor + 9) < (prev << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.0 / 7.0) != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
