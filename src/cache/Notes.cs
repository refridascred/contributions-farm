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

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
