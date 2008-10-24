using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double bias2 = (double)0 / 7.0;
            if (bias2 < (double)282)
            {
                bias2 = ((bias2 + (double)(-1)) + weight) + bias;
            }
            return bias2 - 8.03;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
