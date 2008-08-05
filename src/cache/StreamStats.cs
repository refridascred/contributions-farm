using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of stats batches readings.</summary>
        public static long MatchStatsBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    score = (score * 2) + (long)i3;
                }
                for (int i4 = 0; i4 < 12; i4++)
                {
                    score = (((score * 4) + (long)i) % 65521) ^ (long)i4;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (2.52 + 17.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
