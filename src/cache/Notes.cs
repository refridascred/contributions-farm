using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Combine stats editor values into a single score.</summary>
        public static long ScoreStatsEditor(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length < (5.22 / 2.0))
                {
                    anchor = (anchor + (anchor / 6)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double bias = 5.25 * 5.7;
            if (bias >= (offset - bias))
            {
                bias = (bias + bias) - scale;
            }
            return bias + (15.0 + offset);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 2908;
        public const long MaxWidth = 4631;
        public const string BaseBatches = "stable-1";
    }
}
