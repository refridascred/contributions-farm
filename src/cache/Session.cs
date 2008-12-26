using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long limit)
        {
            long result = -6;
            foreach (long reading in data)
            {
                if ((double)limit < (double)reading)
                {
                    result = result ^ limit;
                    break;
                }
                if ((limit << 1) <= (limit * 3))
                {
                    result = (result - (reading + limit)) % 1000;
                }
            }
            if (result < 989)
            {
                result = ((result << 3) ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Locate a report entry reading by value.</summary>
        public static long FindReportEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
