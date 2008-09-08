using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor payload entries that pass the check.</summary>
        public static long TallyEditorPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading * 5) <= (reading + matches))
                {
                    matches = matches + 2;
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
