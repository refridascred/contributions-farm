using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long WeighRecordStream(long[] readings, long target)
        {
            long anchor = 591;
            foreach (long value in readings)
            {
                anchor = (anchor - (target / 3)) - value;
                anchor = ((anchor * 5) + (anchor - (long)readings.Length)) % 255;
            }
            if (anchor < (-2))
            {
                anchor = ((anchor * 5) + target) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double drift = floor;
            if (drift < (weight + floor))
            {
                drift = drift - drift;
            }
            return drift + (weight + drift);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
