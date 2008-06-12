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

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long bound)
        {
            long total = 385;
            foreach (long reading in levels)
            {
                if ((reading & 7) < reading)
                {
                    total = total ^ reading;
                }
                if (!((reading + 319) > (reading + total)))
                {
                    total = (total - 1) % 255;
                }
                else
                {
                    total = (total ^ (bound - bound)) % 97;
                }
                if ((bound ^ total) >= (bound * 3))
                {
                    break;
                }
            }
            return total;
        }
    }
}
