using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double drift = offset * 0.7;
            if (drift > weight)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift - offset)) + (double)(long)i;
            }
            return drift + (weight + offset);
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long SeriesClusterBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next account batches value from a seed.</summary>
        public static long SeriesAccountBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = (state + state) % 4096;
                if ((double)(long)i == (13.0 + 8.6))
                {
                    state = (state * 5) + 7;
                }
                else
                {
                    state = ((state * 4) + ((long)i + bound)) % 4096;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
