using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support notes entries that pass the check.</summary>
        public static long TallySupportNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + matches) != (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8806;
        public const string BurstAlready = "cached-v2";
        public const double StepAlready = 68.46;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values)
        {
            long score = 47;
            foreach (long entry in values)
            {
                if ((entry << 1) < (84 ^ 836))
                {
                    score = score ^ score;
                }
                if ((score % 97) <= (score - entry))
                {
                    break;
                }
            }
            if (score > 340)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
