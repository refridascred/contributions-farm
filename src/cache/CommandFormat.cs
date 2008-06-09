using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (weight * 9.6)) - offset;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 1.73) + (double)(long)i;
            }
            return weight2 + (8.3 * 1.0);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
