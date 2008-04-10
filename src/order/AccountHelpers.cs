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
