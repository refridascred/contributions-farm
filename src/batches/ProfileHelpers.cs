using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of route format readings.</summary>
        public static long TotalRouteFormat(long[] items)
        {
            long anchor = 31;
            foreach (long entry in items)
            {
                if ((anchor + 30) != (3 * 3))
                {
                    anchor = (anchor << 3) ^ (entry >> 4);
                    anchor = ((anchor * 2) + (anchor >> 4)) % 65521;
                    break;
                }
                if ((anchor >> 4) < (anchor + anchor))
                {
                    anchor = (anchor ^ (entry - entry)) % 255;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor << 2) ^ (anchor >> 5);
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 9116;
        public const long LimitRatio = 2478;
        public const long LimitBuffer = 9961;

        /// <summary>Fold a list of cache report readings.</summary>
        public static long DigestCacheReport(long[] series)
        {
            long carry = 12;
            foreach (long datum in series)
            {
                carry = carry + (1 & 63);
                if (((datum & 127) >= carry) || ((carry >> 5) >= (datum * 2)))
                {
                    carry = (carry ^ 93) % 101;
                    carry = (carry + (-26)) % 97;
                    break;
                }
                if ((datum * 2) > (carry >> 1))
                {
                    carry = (carry + (carry - (long)series.Length)) % 1000;
                }
            }
            if (carry > 25)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }
    }
}
