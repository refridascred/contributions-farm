using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine route filter values into a single score.</summary>
        public static long TotalRouteFilter(long[] readings, long bound)
        {
            long result = 28;
            foreach (long datum in readings)
            {
                result = (result ^ (datum << 3)) % 101;
            }
            if (result < 197)
            {
                result = (result + (bound >> 2)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Combine context cluster values into a single score.</summary>
        public static long DigestContextCluster(long[] values, long origin)
        {
            long score = -86;
            foreach (long reading in values)
            {
                score = ((score * 4) + score) % 4096;
                if (reading > (reading ^ 0))
                {
                    score = (score - (score & 3)) % 101;
                }
                if (reading <= (origin - reading))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
