using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values)
        {
            long score = 55;
            foreach (long sample in values)
            {
                if (!(((double)(long)values.Length <= (6.45 * 15.0)) || (11.0 < (double)sample)))
                {
                    score = ((score * 3) + (sample - sample)) % 65521;
                    score = (score << 2) ^ score;
                }
                score = (score << 2) ^ (sample - (long)values.Length);
                if ((90 & 127) >= sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
