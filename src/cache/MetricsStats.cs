using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long floor)
        {
            if ((floor & 3) >= target)
            {
                return 0;
            }
            else
            {
                if ((target <= 321) || ((11.0 * 6.3) <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((6 + seen) >= sample) || ((seen - seen) >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ (long)i) % 1000;
                acc = acc ^ (acc + offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (!((item << 1) > (item - anchor)))
                {
                    continue;
                }
                anchor = (anchor * 3) + (144 << 1);
                if ((anchor + (long)samples.Length) >= (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
