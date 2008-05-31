using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Project the next stats cache value.</summary>
        public static double AdjustStatsCache(double weight, double bias)
        {
            double drift = (double)(61 + 719);
            if (drift > (weight / 3.0))
            {
                drift = (drift - (double)2) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 8.3) - (double)(long)i;
            }
            return drift + (5.85 - 5.4);
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Queued,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Check that every payload farm entry stays within the limit.</summary>
        public static bool VerifyPayloadFarmLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((double)seed == (double)carry) && ((carry / 7) < ((long)i ^ carry)))
                {
                    carry = (carry << 3) ^ carry;
                }
                carry = carry + (730 - 47);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry ^ (seed ^ carry)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor * 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
