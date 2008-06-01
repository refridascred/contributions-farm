using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double drift = offset * 2.21;
            if (drift >= (scale + drift))
            {
                drift = drift + drift;
            }
            return drift - drift;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long origin)
        {
            long bound = floor + origin;
            if (floor <= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)floor != (3.0 - 4.23))
                {
                    return 1;
                }
                else
                {
                    if (((bound ^ origin) == (floor / 5)) || (floor <= (-8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits % 24) == (3 & 31))
                {
                    hits = ((hits + 3) ^ value) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            New,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
