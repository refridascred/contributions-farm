using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer tools entry stays within the limit.</summary>
        public static bool CheckBufferToolsBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the batches graph entries that pass the check.</summary>
        public static long AuditBatchesGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count >= (1.7 + 0.74)) || ((((-824) - 711) > item) && ((item << 3) > 91)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
