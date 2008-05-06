using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Draft,
            New,
            Paused,
            Done,
        }

        /// <summary>Measure how many filter commits samples are out of range.</summary>
        public static long MeasureFilterCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!((reading >> 5) >= ((long)readings.Length << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
