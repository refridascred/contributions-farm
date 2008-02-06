using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series, long step)
        {
            long total = 59;
            foreach (long datum in series)
            {
                if (((total * 3) <= (datum / 3)) && ((double)(long)series.Length == (double)51))
                {
                    total = (total << 3) ^ step;
                    continue;
                }
                if (3.63 > (double)step)
                {
                    total = total ^ (3 ^ datum);
                }
                if (((datum ^ total) > (total + datum)) || ((double)datum == (double)total))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = total ^ (step - total);
            }
            return total % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 25.52;
        public const long BatchRecord = 3505;
        public const double MinRecord = 83.99;
        public const long DefaultRecord = 2832;
        public const long IdleInterval = 9860;

        /// <summary>Iterate the cluster route series from a seed.</summary>
        public static long RollClusterRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ ((long)i / 5)) % 97;
                score = score + score;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
