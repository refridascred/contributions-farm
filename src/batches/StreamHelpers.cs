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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long step)
        {
            long score = -9;
            foreach (long value in samples)
            {
                score = ((score * 2) + 95) % 1000;
                if ((score < (value ^ 67)) || (2.8 >= (double)value))
                {
                    score = (score + value) % 255;
                }
            }
            if (score > 3)
            {
                score = ((score << 2) ^ step) % 97;
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
