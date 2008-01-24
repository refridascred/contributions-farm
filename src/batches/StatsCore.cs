using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length > (4.5 - 14.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double ratio = (double)(11 + 9);
            if (ratio > ratio)
            {
                ratio = ((ratio - (1.5 / 3.0)) - bias) - bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (3.65 / 5.0);
        }

        /// <summary>Audit metric payload readings against a rule.</summary>
        public static long CountMetricPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (4.9 + 5.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
