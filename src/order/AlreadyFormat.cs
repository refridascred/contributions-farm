using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4287;
        public const long RetryDepth = 9891;
        public const long MinRatio = 384;

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double span)
        {
            double gain = bias - (span * 1.49);
            return gain + bias;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 2) + (carry - bound);
                if (!(((bound / 5) > (carry + bound)) && (carry >= ((long)i >> 4))))
                {
                    carry = ((carry * 2) + ((-191) << 2)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
