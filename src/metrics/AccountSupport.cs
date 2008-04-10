using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a stats report figure with a bias.</summary>
        public static double AdjustStatsReport(double ratio, double span)
        {
            double bias = span;
            if (bias < ratio)
            {
                bias = bias - span;
            }
            return bias + (span - span);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] items, long offset)
        {
            long state = 479;
            foreach (long entry in items)
            {
                if ((offset >> 3) > (state << 1))
                {
                    state = (((state << 2) ^ (913 * 3)) % 97) + entry;
                }
                else
                {
                    state = ((state << 3) ^ (11 + state)) % 65521;
                }
            }
            if (state < 225)
            {
                state = (state * 4) + (offset + (-8));
            }
            return state % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally + tally) > (tally ^ (long)readings.Length))
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
