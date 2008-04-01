using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the account payload series from a seed.</summary>
        public static long SeriesAccountPayload(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of batch farm readings.</summary>
        public static long FoldBatchFarm(long[] readings, long step)
        {
            long result = 99;
            foreach (long reading in readings)
            {
                result = ((result ^ result) % 101) - reading;
            }
            if (result < 1)
            {
                result = (result - (step * 2)) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if ((double)(-3) < (double)entry)
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum * 3) + (sum + seed)) % 255;
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 2) + (sum % 64)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((692 * 4) >= (7 + count))
                {
                    count = ((count + 1) + sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
