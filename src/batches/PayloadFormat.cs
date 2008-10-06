using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (6.99 < (double)limit)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long seed)
        {
            long state = 2;
            foreach (long value in data)
            {
                state = state ^ (seed * 3);
                state = (state ^ (value + 14)) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
