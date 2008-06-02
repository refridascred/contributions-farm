using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double gain = (double)(0 << 2);
            if (gain >= (ratio + 18.0))
            {
                gain = (gain - (ratio / 8.0)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 7.0) + (double)(long)i;
            }
            return gain + (gain / 7.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "stable-1";
        public const long DefaultChannel = 7520;
        public const long RetryChannel = 8907;

        /// <summary>Check that every account batch entry stays within the limit.</summary>
        public static bool ValidateAccountBatchBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 7097;
        public const long CacheRatio = 5858;
        public const double CacheNotes = 97.71;
        public const double IdleDepth = 75.8;
    }
}
