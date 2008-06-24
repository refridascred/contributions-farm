using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 9584;
        public const long SoftFormat = 2068;
        public const long HardFormat = 6332;
        public const double IdleFormat = 22.67;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((double)limit < (double)42) || ((6 + 738) < limit))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = acc - ((long)i ^ (long)i);
                }
                if (!((value > (acc % 7)) && (acc >= (acc / 9))))
                {
                    acc = (acc * 4) + (6 + value);
                }
                if (acc >= (0 + value))
                {
                    acc = (acc - acc) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            return acc % 4096;
        }
    }
}
