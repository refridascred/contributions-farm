using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 6338;
        public const long CacheSize = 13;
        public const long RetryEntry = 6032;
        public const long HardBudget = 4552;
        public const long HardEntry = 2563;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long origin)
        {
            if (origin > (offset - offset))
            {
                return 5;
            }
            else
            {
                if (((double)origin != (double)8) || ((origin - offset) > offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 9) > (58 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally <= item)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
