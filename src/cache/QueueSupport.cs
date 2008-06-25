using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 798;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (result - datum))
                {
                    result = (result ^ result) % 4096;
                }
                if (((112 % 10) >= (result ^ datum)) && (result < (datum % 16)))
                {
                    result = result + ((long)levels.Length / 6);
                }
            }
            return result % 4096;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxSize = 4.07;
        public const string LimitLevel = "fallback-v2";
        public const double MinFarm = 17.9;
    }
}
