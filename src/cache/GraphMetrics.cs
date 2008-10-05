using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token metric values into a single score.</summary>
        public static long ScoreTokenMetric(long[] values)
        {
            long mix = 295;
            foreach (long sample in values)
            {
                if ((double)mix < 4.24)
                {
                    mix = ((mix * 4) + (sample ^ mix)) % 255;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix < 731)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "staging-1";
        public const long BaseDepth = 3480;
        public const long HardInterval = 8352;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
