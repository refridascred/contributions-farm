using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next queue tools value from a seed.</summary>
        public static long StepQueueTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 3) ^ (817 / 4)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = -85;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix - (mix + (-533))) % 4096) ^ (long)i;
                }
                if ((9.0 - 5.2) != (double)reading)
                {
                    mix = (mix - (mix ^ 186)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if ((limit2 <= (limit2 >> 5)) || ((limit2 + limit) > (0 + 879)))
            {
                return 2;
            }
            else
            {
                if (limit2 >= limit)
                {
                    return 3;
                }
                else
                {
                    if ((120 + limit2) < (limit2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit * 5) > limit)
                {
                    sum = ((sum << 2) ^ ((long)i - sum)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
