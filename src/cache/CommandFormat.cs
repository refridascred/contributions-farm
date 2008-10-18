using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two checks command measurements.</summary>
        public static double ProjectChecksCommand(double weight, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (weight + 7.8);
            }
            return mean - (double)1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double load = (double)(76 >> 3);
            if (load <= (rate + 1.2))
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - rate;
        }
    }
}
