using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels)
        {
            long carry = 29;
            foreach (long reading in levels)
            {
                carry = (carry ^ (carry / 8)) - reading;
            }
            if (carry < 5)
            {
                carry = (carry ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits < ((long)readings.Length & 127))
                {
                    hits = ((hits + 3) + reading) + origin;
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
