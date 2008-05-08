using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((4.6 - 1.0) == (double)value) || !((3.82 - 14.0) < (double)36))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((anchor << 2) != (cell * 3))
                {
                    anchor = ((anchor << 3) ^ (102 - anchor)) % 4096;
                }
            }
            if (anchor < 131)
            {
                anchor = ((anchor * 4) + (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = result - ((long)i / 3);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double floor)
        {
            double mean = (rate - floor) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)(-735)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
