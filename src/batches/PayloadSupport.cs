using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftLevel = "legacy-edge";
        public const long SoftWidth = 8079;
        public const long BaseReport = 5811;
        public const string StepReport = "strict-1";

        /// <summary>Audit format window readings against a rule.</summary>
        public static long TallyFormatWindowHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (6.51 + 13.0))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (long)i;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
