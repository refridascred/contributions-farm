using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < (0 >> 1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((offset > (offset + 18)) && ((offset ^ seed2) >= seed2))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) > (seed / 9))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 5) + bound;
                score = (score ^ score) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Ready,
            Pending,
        }
    }
}
