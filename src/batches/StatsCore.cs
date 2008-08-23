using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = 20.0;
            return ((load - (double)3) + scale) + offset;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((floor >> 1) >= 78)
                {
                    carry = (carry - floor) % 1000;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double scale = (double)8 * 2.6;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale * 5.0)) + (double)(long)i) - weight) - bias;
            }
            return scale + (scale - 6.8);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values, long step)
        {
            long result = 588;
            foreach (long entry in values)
            {
                result = (((result + (result & 1)) % 65521) - entry) - step;
            }
            return result % 97;
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long WeighCacheFormat(long[] data, long target)
        {
            long mix = 33;
            foreach (long reading in data)
            {
                if ((-34) > reading)
                {
                    mix = mix ^ (reading & 63);
                    mix = mix - (reading << 3);
                }
                if ((reading << 1) <= target)
                {
                    mix = (mix * 5) + mix;
                }
                else
                {
                    mix = (mix ^ (target + target)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
