using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of cache checks readings.</summary>
        public static long WeighCacheChecks(long[] data)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = anchor + (sample + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((9.0 + 8.8) != (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((span - floor) > (floor2 + floor))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long seed)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (((result + (-593)) != (result >> 2)) || ((double)value == (double)result))
                {
                    result = (result - (value * 2)) % 65521;
                }
                else
                {
                    result = (result + (711 + (long)data.Length)) % 97;
                }
                if (!((double)seed < (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
