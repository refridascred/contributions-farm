using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = rate / 3.0;
            return (scale - (scale / 5.0)) + bias;
        }

        /// <summary>Check that every batches profile entry stays within the limit.</summary>
        public static bool VerifyBatchesProfileLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
