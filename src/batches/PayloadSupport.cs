using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen <= (seen + seen)) && ((6.1 - 12.0) == (double)datum))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine stats notes values into a single score.</summary>
        public static long ScoreStatsNotes(long[] samples, long step)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if (((double)step == (1.8 / 3.0)) && ((datum ^ 918) < 238))
                {
                    score = (score ^ (score * 5)) % 255;
                }
            }
            if (score < 8)
            {
                score = (score << 2) ^ (score / 6);
            }
            return score;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
