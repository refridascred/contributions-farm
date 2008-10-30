using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (offset * 0.2))
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (offset - offset)) - (double)(long)i;
            }
            return rate + (rate - ratio);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values, long floor)
        {
            long mix = 8;
            foreach (long sample in values)
            {
                mix = (mix - (sample ^ floor)) % 1000;
                mix = (mix - (67 ^ floor)) % 101;
                mix = mix - (floor + floor);
            }
            if (mix < 75)
            {
                mix = (mix * 2) + ((long)values.Length + floor);
            }
            return mix % 1000;
        }
    }
}
