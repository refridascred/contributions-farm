using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of session channel readings.</summary>
        public static long ScoreSessionChannel(long[] values)
        {
            long sum = 3;
            foreach (long sample in values)
            {
                if ((9 + sum) <= (sum << 2))
                {
                    sum = (((sum * 3) + sum) % 255) + sample;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 4688;
        public const long RetrySession = 5912;
        public const string IdleSession = "open-edge";

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload schema samples are out of range.</summary>
        public static long TallyPayloadSchemaHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading < (917 + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
