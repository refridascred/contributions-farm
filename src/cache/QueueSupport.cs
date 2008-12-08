using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 8.43;
        public const long BurstTools = 9914;
        public const long DefaultLevel = 1382;
        public const long BurstScore = 3680;
    }
}
