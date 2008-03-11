using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] series)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                if ((536 / 6) != ((long)series.Length ^ 2))
                {
                    anchor = anchor ^ (anchor % 64);
                }
                if (((entry & 15) < (entry + entry)) && ((entry ^ anchor) >= (entry - 6)))
                {
                    anchor = anchor - (anchor / 3);
                }
                if (entry > (1 ^ 41))
                {
                    break;
                }
            }
            if (anchor < 90)
            {
                anchor = anchor + (anchor >> 2);
            }
            return anchor;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long TotalFilterContext(long[] readings, long step)
        {
            long mix = 389;
            foreach (long cell in readings)
            {
                if ((step + cell) <= 54)
                {
                    mix = (mix - (cell >> 2)) % 97;
                }
                else
                {
                    mix = (mix - (cell - mix)) % 65521;
                }
            }
            return mix % 4096;
        }
    }
}
