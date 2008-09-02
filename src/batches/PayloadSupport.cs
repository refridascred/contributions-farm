using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
