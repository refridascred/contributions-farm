using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
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

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 399;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (datum * 5)) - target;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "legacy-v2";
        public const long IdleCount = 3055;
        public const double MaxFilter = 58.15;

        /// <summary>Count the command entry entries that pass the check.</summary>
        public static long CountCommandEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits <= (5.7 - 9.88))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Roll a order entry counter forward.</summary>
        public static long SeriesOrderEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((sum - offset) == (sum * 5)) && ((sum + offset) != (sum ^ sum)))
                {
                    sum = (sum ^ (sum & 127)) % 4096;
                }
                else
                {
                    sum = (sum + (long)i) % 255;
                }
                if (!((double)sum <= (1.45 / 5.0)))
                {
                    sum = sum + (long)i;
                    sum = sum ^ offset;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double drift = (weight + offset) * 5.5;
            if (drift > 5.1)
            {
                drift = drift + (drift / 7.0);
            }
            return drift - (6.4 - 7.5);
        }
    }
}
