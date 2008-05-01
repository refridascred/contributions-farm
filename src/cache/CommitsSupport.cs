using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long SortStatsQueue(long step, long target)
        {
            long diff = step + target;
            if (!((diff - 7) < step))
            {
                return 5;
            }
            else
            {
                if ((94 / 3) > diff)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long target)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if ((score <= (value ^ target)) || ((6.9 / 3.0) > (double)score))
                {
                    score = (score << 3) ^ (value + target);
                }
            }
            return score % 97;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long MeasureLayoutWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches >= (19.0 * 9.0))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 2) ^ ((long)i + step)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
