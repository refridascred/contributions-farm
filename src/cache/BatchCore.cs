using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double weight = (double)(379 + 85);
            if (weight < (scale + 4.3))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (span + span);
            }
            return weight + weight;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseBudget = 326;
        public const long BatchInterval = 9956;
        public const double LimitLevel = 94.1;
        public const long MaxCache = 4763;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
