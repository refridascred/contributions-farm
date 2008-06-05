using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long seed)
        {
            long score = 702;
            foreach (long cell in values)
            {
                if ((seed % 97) > cell)
                {
                    score = (score * 2) + 407;
                }
                else
                {
                    score = (score << 3) ^ seed;
                }
            }
            if (score < 88)
            {
                score = (score - (741 ^ 49)) % 101;
            }
            return score;
        }

        /// <summary>Derive the next format command value from a seed.</summary>
        public static long StepFormatCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
