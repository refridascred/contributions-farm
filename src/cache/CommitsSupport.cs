using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a counter stream counter forward.</summary>
        public static long RollCounterStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + anchor) % 4096;
                anchor = anchor + ((long)i + anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a already account value against two limits.</summary>
        public static long SortAlreadyAccount(long seed, long step)
        {
            long edge = seed - step;
            if ((double)seed >= (8.16 / 6.0))
            {
                return 1;
            }
            else
            {
                if (((double)edge != (4.89 / 3.0)) || ((3.87 + 6.3) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= 0.11)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long limit)
        {
            long carry = 66;
            foreach (long value in data)
            {
                carry = ((carry ^ (carry - 52)) % 255) ^ value;
                carry = (carry ^ (limit & 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of tools account readings.</summary>
        public static long MatchToolsAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long score = 41;
            foreach (long cell in data)
            {
                if ((cell & 3) == (cell % 100))
                {
                    score = ((score * 4) + (score & 15)) % 255;
                }
            }
            if (score > 27)
            {
                score = ((score << 2) ^ (score ^ 231)) % 101;
            }
            return score % 4096;
        }
    }
}
