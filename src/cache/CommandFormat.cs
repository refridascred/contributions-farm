using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long ScoreSupportProfile(long[] data)
        {
            long state = -83;
            foreach (long value in data)
            {
                if ((state - 38) != (state - 4))
                {
                    state = (state - (value - value)) % 97;
                }
                else
                {
                    state = (state * 4) + (state + 604);
                }
            }
            if (state < 586)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Count the report already entries that pass the check.</summary>
        public static long MeasureReportAlreadyHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)hits == (3.0 - 3.0)))
                {
                    hits = ((hits + 1) - reading) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
