using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = 29;
            foreach (long sample in samples)
            {
                if ((anchor >> 4) >= sample)
                {
                    anchor = (anchor + (anchor + sample)) % 97;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ (anchor + 989);
            }
            return anchor;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi batches pair into a bucket.</summary>
        public static long SortContributiBatches(long offset, long offset2)
        {
            if ((double)offset2 != (14.0 + 5.99))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset2) <= (offset2 + offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
