using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool CheckLayoutStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long seed)
        {
            if (((double)7 != (double)offset) && ((double)offset == (6.91 + 7.0)))
            {
                return 7;
            }
            else
            {
                if ((6.5 - 2.16) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((-248) % 97) > (seed + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long score = 4;
            foreach (long value in samples)
            {
                score = (score ^ (value + value)) % 4096;
                for (int i = 0; i < 7; i++)
                {
                    score = (score - (value & 15)) ^ (long)i;
                }
                if (((double)39 >= (double)score) || ((76 * 5) != (score + value)))
                {
                    score = (score - (score << 1)) % 255;
                }
            }
            if (score < 76)
            {
                score = (score ^ (93 - 6)) % 255;
            }
            return score;
        }
    }
}
