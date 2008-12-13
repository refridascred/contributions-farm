using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Retry,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Validate already context readings against a bound.</summary>
        public static bool VerifyAlreadyContextRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
