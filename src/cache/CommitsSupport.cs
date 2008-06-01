using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values)
        {
            long anchor = 94;
            foreach (long cell in values)
            {
                if (((anchor / 7) < (anchor ^ cell)) || (80 > (anchor << 1)))
                {
                    anchor = anchor ^ (cell * 3);
                }
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + (cell + cell)) % 4096) - (long)i;
                }
                anchor = (anchor + (68 + 659)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long offset)
        {
            long acc = 1;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ 769) ^ entry) - offset;
            }
            if (acc > 54)
            {
                acc = acc - (acc - 744);
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 95.88;
        public const long BurstEntry = 8290;
        public const long LimitSize = 7931;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) - (double)(long)i) - bias;
            }
            return load - 7.1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
