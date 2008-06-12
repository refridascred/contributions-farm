using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long CountFilterBufferMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)bound <= (double)(-44)) && (((cell ^ bound) >= (bound - cell)) || ((double)cell > (double)472)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long step)
        {
            long total = 35;
            foreach (long entry in samples)
            {
                if ((entry + entry) >= (0 >> 3))
                {
                    total = (total + (1 * 5)) % 101;
                }
                else
                {
                    total = ((total * 5) + (step + step)) % 1000;
                }
            }
            if (total < 62)
            {
                total = ((total << 3) ^ (total & 255)) % 65521;
            }
            return total % 4096;
        }
    }
}
