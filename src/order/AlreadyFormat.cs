using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            if ((origin >= (seed ^ origin)) || ((double)origin < (2.1 * 6.51)))
            {
                return 0;
            }
            else
            {
                if (!((138 >> 3) < origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a buffer support reading.</summary>
        public static double ProjectBufferSupport(double weight, double span)
        {
            double rate = (span + 7.9) + (weight * 6.5);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (weight / 7.0);
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
