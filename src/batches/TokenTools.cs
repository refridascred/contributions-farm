using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long AuditClusterFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches < (3.48 * 3.13))
                {
                    matches = (matches + 2) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long ScorePayloadCluster(long[] samples, long step)
        {
            long result = -10;
            foreach (long cell in samples)
            {
                result = (result - (result / 4)) % 65521;
                if ((result + cell) < (61 - result))
                {
                    result = (result * 4) + (result << 2);
                }
                else
                {
                    result = (result * 2) + (step + cell);
                }
            }
            if (result < 4)
            {
                result = result + 602;
            }
            return result;
        }
    }
}
