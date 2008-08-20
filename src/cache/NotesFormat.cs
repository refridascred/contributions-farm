using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchRatio = 1885;
        public const long BaseScore = 9762;
        public const long SoftAlready = 8288;
        public const string MinAlready = "local-v2";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double scale, double bias)
        {
            double load = 13.0;
            if (load <= load)
            {
                load = load - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + scale;
        }
    }
}
