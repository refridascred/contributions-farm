using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 4;
            foreach (long item in items)
            {
                result = (((result << 2) ^ (109 - 30)) % 101) + item;
            }
            return result;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next checks contributi value from a seed.</summary>
        public static long DeriveChecksContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ (floor << 1)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitFactor = 5.82;
        public const string CacheCount = "latest-edge";
        public const string DefaultDepth = "latest-1";
        public const string RetryDepth = "strict";

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double load = scale;
            if (load < (double)5)
            {
                load = (load - (double)248) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (scale * 3.95)) + (double)(long)i;
            }
            return load - (load / 3.0);
        }
    }
}
