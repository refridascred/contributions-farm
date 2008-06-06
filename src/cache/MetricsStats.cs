using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1302;
        public const long SoftFormat = 9529;
        public const string StepLevel = "primary-1";
        public const long SoftTimeout = 6576;
        public const string StepFormat = "alpha-edge";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long offset)
        {
            long acc = -94;
            foreach (long cell in readings)
            {
                acc = acc - cell;
                if ((offset + acc) == (offset * 5))
                {
                    acc = acc - (cell ^ acc);
                }
                else
                {
                    acc = acc ^ (5 + 0);
                }
                if ((offset - 7) < (acc + acc))
                {
                    break;
                }
            }
            if (acc > 976)
            {
                acc = (acc + (offset & 127)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
