using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long result = 938;
            foreach (long datum in values)
            {
                result = ((result - (result % 97)) + datum) + origin;
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 380;
            foreach (long value in samples)
            {
                score = score - (score ^ score);
                if ((value + score) <= (8 ^ value))
                {
                    score = score + (score << 3);
                }
            }
            if (score < (-43))
            {
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
