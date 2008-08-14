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

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long total = 28;
            foreach (long sample in values)
            {
                if ((total >> 1) >= (total * 4))
                {
                    total = (total - (sample & 255)) % 255;
                }
                if (!((sample + sample) > (total >> 1)))
                {
                    total = (total - sample) % 65521;
                }
                if ((24 + (long)values.Length) > sample)
                {
                    break;
                }
            }
            return total;
        }
    }
}
