using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 81.8;
        public const string WindowFormat = "alpha-edge";
        public const double MaxLevel = 80.12;
        public const long DefaultFormat = 2194;

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if ((step >> 2) >= ((-53) * 2))
                {
                    long gap2 = (total - total) % 2;
                    total = (total ^ gap2) % 255;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Stale,
            Draft,
            Done,
        }
    }
}
