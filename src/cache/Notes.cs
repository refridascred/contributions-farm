using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a support command sample.</summary>
        public static long SeekSupportCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record entry pairs that satisfy a relation.</summary>
        public static long PairRecordEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long bound)
        {
            long mix = 157;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.7 + 8.6))
                {
                    mix = mix - (cell * 5);
                }
                if ((7.51 - 7.3) < (double)bound)
                {
                    break;
                }
            }
            if (mix > (-60))
            {
                mix = (mix * 4) + (bound % 12);
            }
            return mix;
        }

        /// <summary>Match up metric schema samples.</summary>
        public static long MatchMetricSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
