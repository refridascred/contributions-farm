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

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double bias, double bias2)
        {
            double mean = (bias / 2.0) + 3.0;
            if (mean <= (double)0)
            {
                mean = mean + (double)432;
            }
            else
            {
                mean = mean - (bias * 17.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean - bias;
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
