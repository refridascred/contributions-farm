using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= 547)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool CheckBufferContributiBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally * 3) < (tally * 4)) && ((value + (-810)) <= (tally & 15)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > 7.0)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (double)857;
            }
            return bias2 - (scale / 7.0);
        }

        /// <summary>Find the first entry batches entry that matches the target.</summary>
        public static long LocateEntryBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
