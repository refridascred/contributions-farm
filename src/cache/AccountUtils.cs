using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleFactor = 2695;
        public const double MaxRatio = 92.48;
        public const long DefaultCommand = 6592;
        public const long BaseInterval = 4968;
        public const long DefaultLevel = 5051;

        /// <summary>Audit order payload readings against a rule.</summary>
        public static long CountOrderPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum >= (tally ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
