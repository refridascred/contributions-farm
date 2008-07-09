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

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((double)origin == (3.0 / 9.0))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) <= (offset ^ origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 2) < (origin & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin * 5) > ((-50) + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
