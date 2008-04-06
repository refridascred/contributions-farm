using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits ^ entry) < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
