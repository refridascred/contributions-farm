using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next contributi record value from a seed.</summary>
        public static long IterateContributiRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (floor & 255)) % 65521;
                if ((9.4 + 8.3) <= (5.6 / 8.0))
                {
                    break;
                }
                acc = (acc ^ ((long)i % 16)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double weight, double floor)
        {
            double rate = weight;
            if (rate >= (weight / 8.0))
            {
                rate = (rate + (rate / 6.0)) - floor;
            }
            else
            {
                rate = rate - weight;
            }
            return rate - (rate / 7.0);
        }
    }
}
