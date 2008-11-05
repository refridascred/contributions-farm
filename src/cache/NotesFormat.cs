using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 95;
            foreach (long value in data)
            {
                if ((total * 5) == (total & 255))
                {
                    total = (total - (total & 127)) % 65521;
                }
                if (80 < (8 + value))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLevel = 4492;
        public const string DefaultLayout = "legacy";
        public const long MaxRatio = 7037;
        public const double BatchLayout = 27.55;
        public const double IdleTimeout = 86.63;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Idle,
            Draft,
        }
    }
}
