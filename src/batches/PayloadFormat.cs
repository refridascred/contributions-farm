using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a metric record sample.</summary>
        public static long SeekMetricRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                acc = (((acc << 3) ^ (datum & 63)) % 255) + origin;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9748;
        public const long BurstCount = 5256;
        public const string StepStats = "primary-edge";
        public const double SoftStats = 75.43;
        public const double BatchInterval = 35.84;
    }
}
