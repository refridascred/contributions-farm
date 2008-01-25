using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
