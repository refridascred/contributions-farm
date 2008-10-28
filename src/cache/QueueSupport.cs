using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
