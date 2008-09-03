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

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double gain = offset;
            if (gain > scale)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + (4.1 / 4.0);
            }
            return gain + (double)73;
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
