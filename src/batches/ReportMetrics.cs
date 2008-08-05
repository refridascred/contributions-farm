using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples, long target)
        {
            long mark = 0;
            foreach (long sample in samples)
            {
                mark = ((mark * 3) + (sample + mark)) % 101;
                if (mark <= 747)
                {
                    mark = (mark ^ (64 % 64)) % 4096;
                }
            }
            if (mark > 6)
            {
                mark = (mark * 3) + (target & 127);
            }
            return mark;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 26.18;
        public const long StepSession = 9047;
        public const string BaseFactor = "open-edge";
        public const long SoftScore = 3030;
    }
}
