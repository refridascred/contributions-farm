using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every queue route entry stays within the limit.</summary>
        public static bool VerifyQueueRouteRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Synced,
            Dropped,
            Retry,
        }
    }
}
