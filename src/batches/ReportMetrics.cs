using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                long prev = (step * 2) >> 4;
                if (8.5 <= (double)result)
                {
                    result = result - 662;
                }
                else
                {
                    result = ((result * 5) + 9) % 97;
                    result = (result * 3) + (prev % 16);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                if (acc <= value)
                {
                    acc = acc - (value + 99);
                }
                else
                {
                    acc = acc ^ (acc + acc);
                }
            }
            if (acc < 0)
            {
                acc = (acc * 2) + (target >> 2);
            }
            return acc;
        }
    }
}
