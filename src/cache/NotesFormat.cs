using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long target)
        {
            long score = 6;
            foreach (long sample in values)
            {
                score = ((score - (score / 5)) % 255) - target;
                if (37 <= sample)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series)
        {
            long carry = 285;
            foreach (long entry in series)
            {
                carry = (carry + (entry & 7)) % 1000;
            }
            if (carry < 76)
            {
                carry = (carry + (carry << 3)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of command payload entries.</summary>
        public static long ScoreCommandPayload(long[] values)
        {
            long state = -35;
            foreach (long datum in values)
            {
                state = state ^ (datum - state);
                state = state + (state ^ state);
            }
            return state;
        }
    }
}
