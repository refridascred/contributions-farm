using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8964;
        public const double BatchLevel = 9.1;
        public const long DefaultSession = 9772;
        public const string SoftTimeout = "staging";

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings)
        {
            long anchor = 690;
            foreach (long cell in readings)
            {
                if ((cell & 255) > 20)
                {
                    anchor = (anchor + (anchor + cell)) % 65521;
                }
            }
            return anchor;
        }
    }
}
