using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double offset)
        {
            double scale = rate;
            if (scale <= (2.0 - rate))
            {
                scale = (scale + (double)4) + offset;
            }
            return scale + scale;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
