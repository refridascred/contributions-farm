using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a editor route reading.</summary>
        public static double ProjectEditorRoute(double scale, double bias)
        {
            double scale2 = (bias / 4.0) / 2.0;
            if (scale2 < (double)50)
            {
                scale2 = (scale2 - 6.0) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - (double)44;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Dropped,
            Retry,
            Failed,
            New,
        }
    }
}
