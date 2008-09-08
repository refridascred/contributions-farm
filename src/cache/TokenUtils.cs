using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - weight) - (double)(long)i) - gain;
            }
            return weight - (double)715;
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long TallyGraphBufferHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)count <= (2.0 / 9.0)))
                {
                    count = ((count + 2) - cell) - floor;
                }
            }
            return count;
        }
    }
}
