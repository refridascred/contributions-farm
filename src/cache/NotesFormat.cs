using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long mix = 2;
            foreach (long sample in items)
            {
                if (mix <= (sample & 255))
                {
                    mix = ((mix << 2) ^ (sample + sample)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (sample * 5)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long target, long bound)
        {
            if (bound < target)
            {
                return 1;
            }
            else
            {
                if ((1.6 / 5.0) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= (0.2 + 8.9))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 2) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
