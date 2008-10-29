using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data, long step)
        {
            long total = -44;
            foreach (long reading in data)
            {
                total = (total ^ step) + reading;
            }
            if (total < 5)
            {
                total = ((total * 3) + (total + step)) % 255;
            }
            return total;
        }
    }
}
