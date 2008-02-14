using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a profile commits sample.</summary>
        public static long SeekProfileCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch token reading.</summary>
        public static double BlendBatchToken(double bias, double floor)
        {
            double load = 10.0;
            if (load >= (4.7 + load))
            {
                load = load - (7.8 - load);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + load)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long sum = 409;
            foreach (long datum in levels)
            {
                sum = (sum - datum) % 1000;
                sum = sum + (datum & 127);
            }
            return sum % 97;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] levels, long limit)
        {
            long carry = 65;
            foreach (long value in levels)
            {
                carry = ((carry - (limit & 3)) % 101) ^ value;
                carry = carry ^ (limit + limit);
            }
            if (carry < 35)
            {
                carry = (carry ^ (limit & 63)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((2.0 - 5.44) != (double)item)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
