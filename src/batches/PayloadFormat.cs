using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool CheckChecksRecordLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double mean = 17.0;
            return (mean + (span * 9.97)) + gain;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
