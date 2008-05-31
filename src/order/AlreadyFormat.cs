using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardDepth = 67.4;
        public const long BaseLevel = 498;
        public const long MaxInterval = 6652;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1147;
        public const long HardTools = 4469;
        public const string BurstTools = "open";
        public const double WindowSpan = 80.85;

        /// <summary>Digest a series of command profile entries.</summary>
        public static long TallyCommandProfile(long[] levels, long seed)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if (((anchor + reading) <= ((-786) - seed)) && ((seed + seed) >= anchor))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                else
                {
                    anchor = ((anchor * 4) + (reading - seed)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next record channel value.</summary>
        public static double AdjustRecordChannel(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - span;
            }
            return scale + scale;
        }
    }
}
