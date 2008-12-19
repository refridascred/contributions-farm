using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels, long bound)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                total = total + bound;
                if ((bound ^ entry) <= (entry ^ entry))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = ((total * 4) + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long CountReportContextHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)8 == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double weight = (double)2 + (floor * 3.2);
            if (weight <= (weight - 2.25))
            {
                weight = weight + ratio;
            }
            return weight - (weight - floor);
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
