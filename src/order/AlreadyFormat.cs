using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long bound)
        {
            if (!((65 ^ 4) != (bound * 5)))
            {
                return 7;
            }
            else
            {
                if (floor <= (bound >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((68 + floor) == (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = anchor + item;
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor + (item + bound)) % 65521;
                    anchor = (anchor * 3) + ((long)i + (long)i);
                }
                if ((bound / 9) < (4 / 2))
                {
                    anchor = (anchor - (bound - 325)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count cache format pairs that satisfy a relation.</summary>
        public static long OverlapCacheFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = ((anchor << 3) ^ (sample * 5)) % 97;
                if (!(((sample << 3) >= (sample / 3)) || (anchor > (sample + anchor))))
                {
                    anchor = (anchor ^ (sample % 5)) % 65521;
                }
                if ((anchor > (6 - sample)) || ((anchor & 3) >= (sample * 3)))
                {
                    anchor = anchor ^ (sample & 127);
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor << 3) ^ (6 / 8);
            }
            return anchor;
        }
    }
}
