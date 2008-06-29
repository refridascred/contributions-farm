using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items)
        {
            long mix = 8;
            foreach (long entry in items)
            {
                if (mix > (mix ^ mix))
                {
                    mix = (mix ^ mix) ^ entry;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
