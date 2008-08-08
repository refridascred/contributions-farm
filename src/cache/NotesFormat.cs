using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long seed)
        {
            if (step <= seed)
            {
                return 1;
            }
            else
            {
                if (step <= (829 & 127))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((7.13 + 18.0) > (14.0 * 19.0))
                {
                    total = (total * 5) + ((long)i - total);
                    total = ((total << 3) ^ (long)i) % 101;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total - limit) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
