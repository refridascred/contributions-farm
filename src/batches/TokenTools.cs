using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Queued,
            Ready,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
