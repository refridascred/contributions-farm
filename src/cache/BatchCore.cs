using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Synced,
            Done,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - offset;
                anchor = (anchor + (55 - 207)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema token readings.</summary>
        public static long ScoreSchemaToken(long[] values)
        {
            long sum = -47;
            foreach (long reading in values)
            {
                if ((reading / 9) == (sum + sum))
                {
                    sum = (sum ^ (reading + 8)) % 255;
                }
            }
            if (sum > 246)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Compare every pair of metrics counter readings.</summary>
        public static long OverlapMetricsCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
