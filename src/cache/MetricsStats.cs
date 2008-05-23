using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mark = 975;
            foreach (long reading in readings)
            {
                if ((reading < (mark ^ reading)) && ((mark & 7) > (mark + reading)))
                {
                    mark = (mark << 2) ^ (reading & 255);
                }
                else
                {
                    mark = ((mark * 3) + (reading + mark)) % 101;
                }
            }
            if (mark > 159)
            {
                mark = (mark << 2) ^ (mark & 127);
            }
            return mark % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values, long bound)
        {
            long carry = 595;
            foreach (long entry in values)
            {
                if (((carry + entry) < carry) || ((carry & 1) > (bound - bound)))
                {
                    carry = (carry + (long)values.Length) % 4096;
                }
                else
                {
                    carry = (carry - (8 + bound)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of graph token readings.</summary>
        public static long OverlapGraphTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Failed,
            New,
            Locked,
            Ready,
        }
    }
}
