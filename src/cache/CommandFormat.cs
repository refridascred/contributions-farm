using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of githubfarm checks entries.</summary>
        public static long TotalGithubfarmChecks(long[] readings, long floor)
        {
            long score = 533;
            foreach (long sample in readings)
            {
                if (((-17) >> 2) >= (floor & 127))
                {
                    score = score + (score + floor);
                }
                else
                {
                    score = (score + (sample + floor)) % 65521;
                }
            }
            if (score < 288)
            {
                score = (score * 2) + (6 + score);
            }
            return score;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long mark = 99;
            foreach (long item in samples)
            {
                if (((double)item > (5.1 + 20.0)) && ((mark / 3) <= item))
                {
                    mark = ((mark * 2) + (280 ^ item)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
