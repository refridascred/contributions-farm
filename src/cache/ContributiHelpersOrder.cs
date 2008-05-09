using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next report route value.</summary>
        public static double ProjectReportRoute(double rate, double bias)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (rate * 0.5);
            }
            else
            {
                drift = drift + (drift - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift / 3.0)) + (double)(long)i;
            }
            return drift - 6.31;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long bound)
        {
            long score = 40;
            foreach (long value in samples)
            {
                if ((value + (long)samples.Length) != (bound + value))
                {
                    score = (score << 3) ^ (940 / 5);
                }
            }
            if (score > 573)
            {
                score = (score ^ (score / 7)) % 1000;
            }
            return score % 1000;
        }
    }
}
