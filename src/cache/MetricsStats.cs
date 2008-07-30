using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double gain = (double)409 - (double)75;
            if (gain > bias)
            {
                gain = gain - (gain / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight - gain)) + (double)(long)i;
            }
            return gain + 7.09;
        }

        /// <summary>Compare every pair of session layout readings.</summary>
        public static long OverlapSessionLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
