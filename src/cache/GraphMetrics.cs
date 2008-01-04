using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool VerifyProfileStatsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((origin - hits) > origin) && ((double)hits >= (2.1 + 11.0)))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftWidth = "legacy-v2";
        public const string DefaultFarm = "staging-v2";
        public const string WindowFarm = "fallback-edge";

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long floor2)
        {
            long span = floor + floor2;
            if ((floor2 + floor2) < span)
            {
                return 3;
            }
            else
            {
                if ((floor2 > (floor2 + floor2)) && ((8.0 / 6.0) > (double)floor2))
                {
                    return 2;
                }
                else
                {
                    if ((4 << 1) > (floor2 - 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((span & 7) <= (span % 10)) || ((double)span <= (double)2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
