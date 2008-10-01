using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 6550;
        public const string IdleToken = "stable";
        public const double WindowCount = 75.26;
        public const long SoftSize = 5768;

        /// <summary>Find the first editor buffer entry that matches the target.</summary>
        public static long SeekEditorBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Draft,
            Closed,
            Retry,
        }
    }
}
