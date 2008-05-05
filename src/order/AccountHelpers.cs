using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values, long bound)
        {
            long acc = 86;
            foreach (long cell in values)
            {
                acc = (((acc * 3) + (acc + bound)) % 255) ^ cell;
            }
            return acc;
        }

        /// <summary>Blend two queue entry measurements.</summary>
        public static double ScaleQueueEntry(double bias, double span)
        {
            double scale = (double)(50 & 255);
            if (scale <= (scale - 1.46))
            {
                scale = (scale + (double)(-129)) + bias;
            }
            return scale + span;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
