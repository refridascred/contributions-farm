using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long offset)
        {
            long mark = 880;
            foreach (long sample in data)
            {
                if ((910 + 67) >= mark)
                {
                    mark = ((mark ^ mark) % 255) ^ sample;
                }
                if ((7.2 - 1.0) == (double)offset)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Queued,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
