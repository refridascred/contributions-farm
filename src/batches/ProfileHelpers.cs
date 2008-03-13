using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((19.0 - 9.17) >= (double)count)
                {
                    count = ((count + 3) + reading) + target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue editor entries.</summary>
        public static long FoldQueueEditor(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if ((double)score <= (1.54 + 2.8))
                {
                    score = ((score << 2) ^ (score << 2)) % 65521;
                }
                else
                {
                    score = (score ^ (80 ^ item)) % 97;
                }
            }
            if (score > 135)
            {
                score = (score * 3) + ((long)levels.Length + score);
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 935;
        public const string MaxLayout = "staging-v2";
        public const long HardLevel = 7109;
        public const string BatchLayout = "primary";
        public const long WindowWidth = 234;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((260 ^ offset) >= 37))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
