using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long acc = 20;
            foreach (long entry in readings)
            {
                acc = ((acc + acc) ^ entry) + step;
            }
            if (acc < 8)
            {
                acc = (acc ^ (acc >> 4)) % 101;
            }
            return acc;
        }

        /// <summary>Blend two metrics command measurements.</summary>
        public static double SmoothMetricsCommand(double scale, double floor)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight + (floor * 9.41);
            }
            else
            {
                weight = weight - (double)858;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (scale - scale)) - (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
