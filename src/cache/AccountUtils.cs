using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFactor = 1969;
        public const string DefaultScore = "open-1";
        public const double BatchRatio = 75.76;
        public const long MinFormat = 4997;
        public const double DefaultFormat = 10.88;
    }
}
