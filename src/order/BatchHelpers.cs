using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batches account entries.</summary>
        public static long TallyBatchesAccount(long[] data)
        {
            long anchor = 589;
            foreach (long reading in data)
            {
                if ((anchor + reading) < reading)
                {
                    anchor = (anchor * 5) + ((long)data.Length % 97);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
