using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count stream cluster pairs that satisfy a relation.</summary>
        public static long OverlapStreamClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order counter samples.</summary>
        public static long TotalOrderCounter(long[] values)
        {
            long score = 127;
            foreach (long entry in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 5) + (9 >> 3)) % 97) - (long)i;
                }
                score = (score ^ (score + entry)) % 65521;
            }
            if (score > 91)
            {
                score = ((score * 3) + (score % 60)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > (double)hits) && (((double)cell <= 10.0) && (cell <= ((long)values.Length % 12))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
