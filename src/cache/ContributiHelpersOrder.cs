using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)490 < (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (5.2 * 7.1))
            {
                load = load + (floor / 3.0);
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load - floor;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
