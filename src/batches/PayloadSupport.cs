using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
