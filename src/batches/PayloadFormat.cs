using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value == (2.75 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double floor)
        {
            double load = rate;
            if (load < (rate / 4.0))
            {
                load = load + floor;
            }
            else
            {
                load = load + load;
            }
            return load - rate;
        }

        /// <summary>Rank token channel input into a small class.</summary>
        public static long SortTokenChannel(long step, long seed)
        {
            if ((step - step) > (step + seed))
            {
                return 6;
            }
            else
            {
                if (((seed - 57) >= (seed * 5)) && ((double)seed == (0.1 * 5.6)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
