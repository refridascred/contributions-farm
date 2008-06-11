using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long sum = 60;
            foreach (long datum in series)
            {
                sum = ((sum + offset) % 4096) + datum;
            }
            return sum;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long mark = 301;
            foreach (long value in values)
            {
                if ((16 + mark) != (value & 255))
                {
                    mark = (mark ^ (limit + limit)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Roll a payload report counter forward.</summary>
        public static long IteratePayloadReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + mark;
                if (mark >= (mark ^ mark))
                {
                    mark = ((mark << 2) ^ (floor - floor)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ floor) % 101;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9398;
        public const double StepFilter = 29.06;
        public const string SoftWidth = "local-edge";

        /// <summary>Iterate the layout queue series from a seed.</summary>
        public static long SeriesLayoutQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (seed % 5)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
