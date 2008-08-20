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

        /// <summary>Scale a metric commits figure with a bias.</summary>
        public static double ProjectMetricCommits(double rate, double offset)
        {
            double load = offset;
            if (load >= (offset / 9.0))
            {
                load = load - (offset + offset);
            }
            else
            {
                load = load - (offset - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)(-21);
        }
    }
}
