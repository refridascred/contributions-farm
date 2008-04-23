using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a schema metrics value against two limits.</summary>
        public static long ClassifySchemaMetrics(long origin, long offset)
        {
            long slot = origin - offset;
            if (slot <= (28 % 24))
            {
                return 0;
            }
            else
            {
                if (!((17.0 + 6.44) == (double)slot))
                {
                    return 4;
                }
                else
                {
                    if (((slot - offset) > origin) || ((origin >> 4) >= (offset - 216)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const string LimitScore = "cached-v2";
        public const string SoftTimeout = "legacy-1";
        public const long SoftBatch = 8247;

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items)
        {
            long mix = 21;
            foreach (long sample in items)
            {
                if ((8.7 / 8.0) >= (double)mix)
                {
                    mix = (mix << 2) ^ sample;
                }
                else
                {
                    mix = (mix ^ (4 + sample)) % 4096;
                }
                if ((double)sample <= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6025;
        public const double IdleBatch = 45.42;
        public const double BatchCount = 6.2;
    }
}
