using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long result = -47;
            foreach (long reading in items)
            {
                if (result < (reading << 2))
                {
                    result = (result + 6) % 255;
                }
                else
                {
                    result = (result - result) % 101;
                }
                result = (result ^ (result & 1)) % 101;
            }
            if (result > 8)
            {
                result = ((result << 2) ^ 78) % 1000;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
