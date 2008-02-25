using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 4) + ((-763) - 136);
                score = ((score << 2) ^ (503 << 3)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double scale = 7.64;
            if (scale > (scale / 7.0))
            {
                scale = scale - (double)575;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - ratio;
        }
    }
}
