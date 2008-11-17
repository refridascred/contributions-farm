using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= 1.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue cluster entries.</summary>
        public static long ScoreQueueCluster(long[] values, long origin)
        {
            long carry = 9;
            foreach (long reading in values)
            {
                if ((carry ^ carry) >= (444 / 5))
                {
                    carry = (carry + (reading - origin)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (reading * 5);
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine filter batches values into a single score.</summary>
        public static long FoldFilterBatches(long[] items)
        {
            long carry = 416;
            foreach (long item in items)
            {
                if ((14.0 / 2.0) >= (double)carry)
                {
                    carry = ((carry << 2) ^ (9 % 97)) + item;
                }
                else
                {
                    carry = (carry * 4) + (carry << 3);
                }
            }
            return carry % 1000;
        }
    }
}
