using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next cache order value.</summary>
        public static double AdjustCacheOrder(double weight, double offset)
        {
            double rate = (offset + 8.0) + (double)783;
            if (rate <= (double)160)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (weight / 6.0)) - (double)(long)i;
            }
            return rate - (offset + 2.51);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
