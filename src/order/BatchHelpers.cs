using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
