using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double span)
        {
            double weight = 7.0 - 5.0;
            if (weight < span)
            {
                weight = weight - (double)993;
            }
            else
            {
                weight = weight - (bias - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Count the metric entry entries that pass the check.</summary>
        public static long TallyMetricEntryMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset ^ offset) < (tally / 4))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(matches >= cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
