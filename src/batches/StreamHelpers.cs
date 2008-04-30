using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] series, long limit)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                if ((8.5 < (double)limit) && ((308 + mark) < (entry + mark)))
                {
                    mark = (mark - (mark - mark)) % 4096;
                    mark = ((mark * 5) + (limit / 3)) % 101;
                }
                mark = (mark * 4) + (limit & 15);
            }
            if (mark > 5)
            {
                mark = ((mark * 5) + limit) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long WeighCounterCache(long[] series, long step)
        {
            long total = 4;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total * 3) + (step ^ sample)) + (long)i;
                }
                if ((double)total <= (double)sample)
                {
                    total = ((total << 2) ^ (sample - sample)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i < (acc % 10)) || ((target - acc) <= (target * 3)))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of command commits readings.</summary>
        public static long PairCommandCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
