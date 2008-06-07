using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double rate = floor;
            if (rate < 9.75)
            {
                rate = (rate + floor) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)6) + (double)(long)i;
            }
            return rate - (floor + floor);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if ((score + score) < sample)
                {
                    score = (score * 5) + (9 & 31);
                }
            }
            if (score > (-441))
            {
                score = score ^ (score & 1);
            }
            return score % 4096;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool CheckFarmQueueRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((175 / 8) < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
