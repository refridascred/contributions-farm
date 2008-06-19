using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate window record readings against a bound.</summary>
        public static bool VerifyWindowRecordRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the channel token entries that pass the check.</summary>
        public static long MeasureChannelTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum < 7.2) || !(matches > (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
