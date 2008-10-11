using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(1 > (floor % 3)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
