using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowTimeout = 7962;
        public const string LimitTimeout = "strict-edge";
        public const double SoftFactor = 83.5;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((10.0 / 4.0) >= (double)matches) || (((-13) - item) >= (2 >> 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
