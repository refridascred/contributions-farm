using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double load = (floor + floor) / 4.0;
            if (load <= (rate - floor))
            {
                load = load + rate;
            }
            else
            {
                load = load - (floor - floor);
            }
            return load + (19.0 + load);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally - tally) > datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
