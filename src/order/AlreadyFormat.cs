using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2873;
        public const long HardFarm = 9090;
        public const double SoftFarm = 57.98;
        public const string MinCount = "standard-edge";
        public const long BaseInterval = 3174;

        /// <summary>Fold a list of layout metric readings.</summary>
        public static long DigestLayoutMetric(long[] series)
        {
            long total = 23;
            foreach (long datum in series)
            {
                if ((250 < (total + (long)series.Length)) || ((datum + total) > datum))
                {
                    total = (total + datum) % 1000;
                }
                else
                {
                    total = total + (datum & 255);
                }
            }
            return total;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
