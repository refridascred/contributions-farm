using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultInterval = 9760;
        public const string StepBatches = "staging";
        public const long BaseBatches = 5028;

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long score = -8;
            foreach (long value in items)
            {
                if (((long)items.Length & 127) != (score + score))
                {
                    score = ((score * 4) + (value + value)) % 255;
                }
            }
            if (score < 635)
            {
                score = ((score << 3) ^ (score * 4)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
