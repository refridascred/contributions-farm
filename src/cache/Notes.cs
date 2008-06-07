using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of format context entries.</summary>
        public static long ScoreFormatContext(long[] samples)
        {
            long score = 1;
            foreach (long cell in samples)
            {
                score = score - (score + score);
                if ((double)score > (8.4 * 9.3))
                {
                    score = ((score << 3) ^ (cell & 31)) % 101;
                }
                else
                {
                    score = score + (score & 63);
                }
                if ((score - cell) <= (0 >> 1))
                {
                    score = (score - (8 % 3)) % 1000;
                }
                else
                {
                    score = (score + (cell ^ cell)) % 101;
                }
                if (score <= cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long floor)
        {
            long carry = -718;
            foreach (long entry in items)
            {
                if (((59 + carry) == (entry % 16)) || (carry < entry))
                {
                    carry = ((carry * 5) + floor) % 101;
                }
                else
                {
                    carry = carry - (carry << 2);
                }
            }
            if (carry < (-533))
            {
                carry = (carry + (floor >> 2)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] values, long seed)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = ((result ^ (sample & 15)) % 255) - seed;
            }
            return result;
        }
    }
}
