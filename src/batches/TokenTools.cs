using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a layout channel reading.</summary>
        public static double SmoothLayoutChannel(double ratio, double offset)
        {
            double load = offset;
            return load - (ratio + offset);
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long total = 3;
            foreach (long item in items)
            {
                total = (total << 2) ^ (offset - total);
                if ((double)item >= (4.9 / 7.0))
                {
                    total = (total ^ (total >> 4)) % 4096;
                }
                if (((item + item) >= (total * 2)) && ((double)item <= 3.53))
                {
                    break;
                }
            }
            if (total > 98)
            {
                total = total + (total + offset);
            }
            return total;
        }
    }
}
