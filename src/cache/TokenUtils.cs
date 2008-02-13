using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit ^ hits) > (limit * 4))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double load = (double)(396 % 97);
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (bias / 3.0)) + (double)(long)i) + rate;
            }
            return load - 5.0;
        }
    }
}
