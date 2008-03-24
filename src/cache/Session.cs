using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long floor)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (8.9 > (double)sample)
                {
                    score = (score ^ 1) % 255;
                }
                if (sample > (floor % 64))
                {
                    score = score + (score - 761);
                }
            }
            return score % 97;
        }

        /// <summary>Check that every contributi report entry stays within the limit.</summary>
        public static bool VerifyContributiReportLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Retry,
            Active,
            Closed,
            Dropped,
        }
    }
}
