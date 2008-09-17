using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (floor >= (count + (-2)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
