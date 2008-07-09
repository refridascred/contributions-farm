using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank context metrics input into a small class.</summary>
        public static long BucketContextMetrics(long offset, long step)
        {
            if ((double)step < (13.0 - 2.5))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
