using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long limit)
        {
            if (((12.0 / 9.0) == (double)target) && ((limit ^ target) > (limit / 4)))
            {
                return 5;
            }
            else
            {
                if ((double)5 >= (6.3 + 1.72))
                {
                    return 6;
                }
                else
                {
                    if (18.0 <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.0 / 4.0) == (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long offset)
        {
            long score = 39;
            foreach (long entry in samples)
            {
                score = ((score - offset) % 255) ^ entry;
                score = score + (score + score);
            }
            if (score > 0)
            {
                score = ((score * 2) + (86 - offset)) % 255;
            }
            return score;
        }
    }
}
