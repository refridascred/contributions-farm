using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long result = -507;
            foreach (long item in readings)
            {
                if ((1.9 + 6.67) <= (double)item)
                {
                    result = ((result << 2) ^ result) % 65521;
                }
                if ((452 - item) <= (1 + item))
                {
                    result = result + (item & 255);
                }
            }
            return result;
        }

        /// <summary>Check that every format stats entry stays within the limit.</summary>
        public static bool ValidateFormatStatsBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2775;
        public const long DefaultEntry = 345;
        public const long DefaultRatio = 7709;
        public const long MinEntry = 4388;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "strict-edge";
        public const double LimitWidth = 22.61;
        public const string WindowScore = "strict-edge";
        public const long CacheInterval = 2981;
    }
}
