using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate counter profile samples.</summary>
        public static long DigestCounterProfile(long[] data)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if (!((sample - 27) < (state & 1)))
                {
                    state = ((state * 3) + (sample << 1)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-191) / 3) >= (matches << 3))
                {
                    matches = ((matches + 1) + entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Paused,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long CompareToolsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double offset)
        {
            double drift = offset + (double)863;
            if (drift <= (drift / 5.0))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (offset + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)(-8)) + (double)(long)i;
            }
            return drift - 6.0;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Ready,
            Active,
            Synced,
        }
    }
}
