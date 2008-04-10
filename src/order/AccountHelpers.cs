using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (seen ^ 1))
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (seed - seed)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= offset)
            {
                gain2 = gain2 + 7.9;
            }
            else
            {
                gain2 = gain2 - (gain - 2.4);
            }
            return gain2 - (double)600;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (floor % 16);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor account readings.</summary>
        public static long PairEditorAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
