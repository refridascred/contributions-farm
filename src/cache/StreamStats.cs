using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of editor commits readings.</summary>
        public static long TallyEditorCommits(long[] series)
        {
            long result = 55;
            foreach (long cell in series)
            {
                if (cell > (result << 2))
                {
                    result = (result - (cell + cell)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (result - result)) % 101;
                }
                result = ((result * 2) + (result ^ 24)) % 255;
            }
            if (result > 94)
            {
                result = (result + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale2) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + scale2) - (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
