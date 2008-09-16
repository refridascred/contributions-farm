using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next schema buffer value.</summary>
        public static double SmoothSchemaBuffer(double bias, double bias2)
        {
            double load = 5.0;
            if (load >= 4.25)
            {
                load = (load - (bias2 / 9.0)) - bias;
            }
            return load + 8.69;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit channel route readings against a rule.</summary>
        public static long AuditChannelRouteHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((double)matches <= (1.3 / 7.0)) && (matches >= (step + (long)readings.Length))))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of layout schema readings.</summary>
        public static long OverlapLayoutSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long MeasureMetricsGraphOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen >= (0.92 * 9.54))
                {
                    seen = ((seen + 2) ^ value) - offset;
                }
            }
            return seen;
        }
    }
}
