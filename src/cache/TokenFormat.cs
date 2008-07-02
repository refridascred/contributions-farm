using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples)
        {
            long score = -567;
            foreach (long datum in samples)
            {
                if (((double)score == (double)datum) || ((double)score == (double)772))
                {
                    continue;
                }
                if ((double)score > (14.0 / 6.0))
                {
                    score = (score * 4) + datum;
                }
                if ((score - score) <= (5 & 15))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = (score - (score / 9)) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long limit)
        {
            long state = 947;
            foreach (long sample in series)
            {
                if ((double)limit != (6.0 + 1.5))
                {
                    state = (state + (limit ^ sample)) % 255;
                }
            }
            return state;
        }
    }
}
