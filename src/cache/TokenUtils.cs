using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of editor farm readings.</summary>
        public static long FoldEditorFarm(long[] readings, long origin)
        {
            long sum = 92;
            foreach (long item in readings)
            {
                sum = (sum + sum) % 4096;
                if (((sum - item) < 11) || ((sum + origin) > item))
                {
                    sum = (sum * 4) + (sum << 1);
                }
            }
            return sum;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Failed,
            Stale,
        }
    }
}
