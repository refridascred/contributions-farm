using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long MeasureSupportChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((entry << 1) > (entry / 9)) && ((0.52 * 6.0) != (double)count)) && ((count + 18) > 399))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Paused,
            Queued,
        }
    }
}
