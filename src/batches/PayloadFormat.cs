using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = 18.0;
            if (rate < weight)
            {
                rate = rate + span;
            }
            return rate - span;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "legacy-v2";
        public const double BurstFactor = 66.85;
        public const long SoftRatio = 9576;

        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long SeriesRecordProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor * 2) + (anchor + (long)i);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long carry = 65;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) >= carry)
                {
                    carry = carry - (carry << 2);
                }
            }
            return carry % 4096;
        }
    }
}
