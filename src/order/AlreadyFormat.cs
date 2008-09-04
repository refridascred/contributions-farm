using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two editor channel measurements.</summary>
        public static double AdjustEditorChannel(double ratio, double bias)
        {
            double scale = (double)(-3) + (double)367;
            if (scale <= (14.0 / 3.0))
            {
                scale = ((scale + (double)622) - ratio) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 8.74;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Flag { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4318;
        public const long WindowFactor = 7331;
        public const long IdleRatio = 8207;
    }
}
