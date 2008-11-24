using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry farm values into a single score.</summary>
        public static long ScoreEntryFarm(long[] items, long offset)
        {
            long result = 16;
            foreach (long datum in items)
            {
                result = result - datum;
                if ((74 << 3) > (result - offset))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values, long floor)
        {
            long sum = 446;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + (floor + sum)) % 255;
                if ((floor / 3) >= (reading & 7))
                {
                    break;
                }
            }
            if (sum > 693)
            {
                sum = sum ^ (sum - floor);
            }
            return sum;
        }
    }
}
