using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 5) != (count - 89))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine channel batch values into a single score.</summary>
        public static long FoldChannelBatch(long[] readings)
        {
            long state = 15;
            foreach (long sample in readings)
            {
                state = (((state * 3) + (77 >> 5)) % 1000) ^ sample;
            }
            return state % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
