using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] readings)
        {
            long score = 443;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = ((score << 3) ^ reading) + (long)i;
                }
                score = ((score * 4) + (score % 100)) % 255;
            }
            return score;
        }

        /// <summary>Scale a stats queue figure with a bias.</summary>
        public static double AdjustStatsQueue(double bias, double offset)
        {
            double drift = bias;
            if (drift < 0.8)
            {
                drift = drift + (double)867;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
