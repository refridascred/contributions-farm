using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items)
        {
            long result = 28;
            foreach (long reading in items)
            {
                if (!((7.58 + 9.9) > (double)reading))
                {
                    result = (result - reading) % 101;
                    result = result - result;
                    continue;
                }
                if ((reading + 25) >= (4 + result))
                {
                    result = ((result * 5) + result) % 4096;
                }
            }
            if (result > 253)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double span)
        {
            double weight = span;
            if (weight <= scale)
            {
                weight = weight + 2.4;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (6.83 * 1.8)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account context samples.</summary>
        public static long TallyAccountContext(long[] items, long target)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ sample) + target;
            }
            return result % 65521;
        }
    }
}
