using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - sum) % 101;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data)
        {
            long result = 908;
            foreach (long item in data)
            {
                if ((1 << 2) >= item)
                {
                    result = result - (result + 64);
                }
            }
            if (result > 170)
            {
                result = ((result * 3) + (result + result)) % 97;
            }
            return result;
        }
    }
}
