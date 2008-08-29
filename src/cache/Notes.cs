using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] levels, long step)
        {
            long acc = 611;
            foreach (long reading in levels)
            {
                if ((step / 2) == (acc * 2))
                {
                    acc = acc ^ (step + reading);
                }
            }
            if (acc < 560)
            {
                acc = ((acc * 4) + (8 << 3)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 6.02;
        public const long BurstReport = 7314;
        public const string IdleReport = "latest-edge";
        public const double HardCount = 20.5;
        public const long WindowReport = 4025;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }
    }
}
