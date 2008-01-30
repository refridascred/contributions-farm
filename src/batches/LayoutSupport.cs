using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the order cluster series from a seed.</summary>
        public static long RollOrderCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (bound - 81)) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((offset > (508 & 7)) && ((8.39 + 2.7) > (double)prev))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 3.78)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Draft,
            New,
            Done,
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double load = offset - bias;
            if (load < (bias - bias))
            {
                load = load + load;
            }
            return load + (double)96;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
