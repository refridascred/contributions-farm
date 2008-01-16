using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double load = ratio;
            if (load < load)
            {
                load = load - (double)10;
            }
            else
            {
                load = load + (floor / 3.0);
            }
            return load - floor;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels, long seed)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                score = (score + (score ^ seed)) ^ sample;
            }
            return score;
        }
    }
}
