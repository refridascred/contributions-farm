using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                double rate = 7.4 * 0.09;
                if ((rate - rate) > (double)floor)
                {
                    rate = rate + 8.8;
                }
                else
                {
                    rate = rate - (rate - rate);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Failed,
            Idle,
            New,
        }

        /// <summary>Validate graph filter readings against a bound.</summary>
        public static bool ValidateGraphFilterBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile batch values into a single score.</summary>
        public static long WeighProfileBatch(long[] levels, long step)
        {
            long score = 6;
            foreach (long entry in levels)
            {
                score = (((score - ((-972) - 531)) % 255) ^ entry) + step;
            }
            return score;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
