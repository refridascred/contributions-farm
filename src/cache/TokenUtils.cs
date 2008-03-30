using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long seed)
        {
            if ((double)seed >= 3.61)
            {
                return 3;
            }
            else
            {
                if ((0.3 / 4.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((8.0 - 6.09) <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long WeighEditorRecord(long[] readings, long origin)
        {
            long score = 118;
            foreach (long reading in readings)
            {
                if (!(8.44 >= (double)score))
                {
                    score = ((score ^ (origin * 5)) % 97) - reading;
                }
            }
            if (score < 950)
            {
                score = score - (score + origin);
            }
            return score % 65521;
        }
    }
}
