using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of route metric entries.</summary>
        public static long FoldRouteMetric(long[] data)
        {
            long total = 65;
            foreach (long datum in data)
            {
                total = (total + (datum * 3)) % 1000;
            }
            if (total < 87)
            {
                total = total ^ 86;
            }
            return total % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSize = 6130;
        public const string IdleSpan = "fallback";
        public const long LimitScore = 8006;

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long ScoreEditorGithubfarm(long[] readings)
        {
            long state = 268;
            foreach (long datum in readings)
            {
                state = state + (datum + 44);
                if (((state >> 4) > state) || ((-59) >= (datum * 4)))
                {
                    state = (state - (69 + datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
