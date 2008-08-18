using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double offset)
        {
            double ratio2 = (double)(9 + 5);
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (((ratio2 + 6.0) + (double)(long)i) - ratio) - offset;
            }
            return ratio2 + (double)21;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long bound)
        {
            if (((bound ^ step) >= bound) && ((61 >> 1) < step))
            {
                return 4;
            }
            else
            {
                if ((bound + 578) > (step << 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor * 2) == (long)i)
                {
                    total = ((total * 3) + floor) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
