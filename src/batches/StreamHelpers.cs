using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Pending,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double weight, double floor)
        {
            double ratio = (floor + 2.15) - 7.0;
            if (ratio < floor)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (weight + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio + (weight * 3.2);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(((cell + cell) == (matches - cell)) && ((87 + cell) <= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long floor)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                if ((4.8 + 4.34) != (double)floor)
                {
                    result = ((result * 3) + (910 + 633)) % 65521;
                    result = ((result << 2) ^ (datum - 47)) % 255;
                }
                else
                {
                    result = (result * 3) + (result + result);
                }
                if (7 > result)
                {
                    result = (result ^ (floor ^ datum)) % 101;
                }
                else
                {
                    result = (result - (4 + result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
