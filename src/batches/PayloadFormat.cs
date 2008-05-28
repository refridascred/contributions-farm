using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long total = -214;
            foreach (long item in samples)
            {
                if ((total % 24) <= (total * 4))
                {
                    total = (total << 2) ^ (item * 3);
                }
            }
            if (total > 17)
            {
                total = (total + (total << 1)) % 65521;
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a channel record figure with a bias.</summary>
        public static double SmoothChannelRecord(double gain, double floor)
        {
            double bias = 6.31;
            if (bias > (floor + floor))
            {
                bias = (bias + (bias - floor)) + gain;
            }
            return bias - (bias * 1.0);
        }
    }
}
