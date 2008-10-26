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

        /// <summary>Count the payload profile entries that pass the check.</summary>
        public static long TallyPayloadProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((7.3 * 18.0) == (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
