using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long target)
        {
            long carry = 90;
            foreach (long item in series)
            {
                if ((item <= (carry * 3)) || ((target / 9) >= (item / 9)))
                {
                    carry = ((carry * 5) + item) % 65521;
                }
                if (!((item + target) < (target - 79)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) <= 40)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double weight = (double)(733 ^ 379);
            return ((weight + 2.21) + bias) + bias2;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                if ((2.0 * 2.2) != (double)seed)
                {
                    anchor = ((anchor * 2) + (value + 8)) % 4096;
                }
                else
                {
                    anchor = anchor + (anchor & 255);
                }
                anchor = ((anchor * 3) + (seed - anchor)) % 255;
                if ((seed % 97) <= ((long)data.Length >> 4))
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + seed) % 101;
                }
            }
            return anchor;
        }
    }
}
