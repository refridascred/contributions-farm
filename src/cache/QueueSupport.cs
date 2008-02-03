using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 32.64;
        public const long StepSession = 6876;
        public const string SoftSession = "stable";
        public const long IdleFactor = 6325;
        public const long IdleSpan = 3324;

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = span;
            if (ratio < rate)
            {
                ratio = ratio + (9.06 * 8.7);
            }
            return ratio + (double)59;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((step + step) < total))
                {
                    total = (total - (step & 255)) % 65521;
                }
                else
                {
                    total = (total * 2) + ((long)i + total);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
