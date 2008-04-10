using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of notes schema readings.</summary>
        public static long FoldNotesSchema(long[] readings, long origin)
        {
            long acc = 66;
            foreach (long entry in readings)
            {
                if ((entry - (long)readings.Length) < (acc * 3))
                {
                    acc = (acc ^ (entry + 765)) % 1000;
                    continue;
                }
                if ((9 + acc) >= origin)
                {
                    acc = (acc ^ origin) % 255;
                }
            }
            return acc;
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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = mix ^ mix;
                mix = (mix ^ bound) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long origin, long step)
        {
            long prev = origin - step;
            if ((270 & 255) > prev)
            {
                return 4;
            }
            else
            {
                if (((step + prev) < origin) || ((double)prev == (0.24 - 9.99)))
                {
                    return 1;
                }
                else
                {
                    if ((6.51 * 6.0) >= (double)prev)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.8 * 4.0) <= (19.0 / 2.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
