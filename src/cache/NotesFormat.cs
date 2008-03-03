using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4644;
        public const double HardOrder = 84.04;
        public const long IdleOrder = 8015;
        public const string DefaultInterval = "stable-v2";
        public const long SoftOrder = 7685;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((832 ^ seen) != (seen + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
