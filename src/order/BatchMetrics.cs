using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit record format readings against a rule.</summary>
        public static long AuditRecordFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally ^ 89) > (reading % 24))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Paused,
            Retry,
            New,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double weight = rate;
            if (weight <= offset)
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (rate * 10.0)) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Adjust a token schema reading.</summary>
        public static double SmoothTokenSchema(double scale, double floor)
        {
            double weight = (double)(978 + 5);
            if (weight >= (floor * 5.4))
            {
                weight = weight - (double)66;
            }
            else
            {
                weight = weight + (scale + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)84;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double rate = (double)(62 + 1);
            if (rate > offset)
            {
                rate = rate + (rate / 3.0);
            }
            else
            {
                rate = rate + (3.2 - offset);
            }
            return rate + (bias * 5.8);
        }
    }
}
