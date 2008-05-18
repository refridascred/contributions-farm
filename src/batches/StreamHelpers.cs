using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 48;
            foreach (long entry in items)
            {
                if ((entry & 15) > (anchor & 1))
                {
                    anchor = (anchor << 2) ^ (entry & 31);
                }
                anchor = (anchor ^ 374) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Done,
            New,
            Draft,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Idle,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 50.22;
        public const double MaxDepth = 76.41;
        public const string SoftWidth = "local-edge";
    }
}
