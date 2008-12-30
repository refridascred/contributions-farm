using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of report payload readings.</summary>
        public static long TotalReportPayload(long[] readings)
        {
            long sum = 36;
            foreach (long sample in readings)
            {
                long next = (998 + 40) ^ (sample - sample);
                sum = (sum ^ next) % 1000;
                sum = (sum - sample) % 97;
                if ((sum ^ sum) >= (sum & 255))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
