using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                anchor = anchor - (anchor + entry);
                if ((seed < (entry & 63)) || (13.0 >= (double)entry))
                {
                    long cur = 27 >> 1;
                    anchor = ((anchor * 2) + cur) % 255;
                    continue;
                }
                if ((entry + anchor) <= (anchor >> 5))
                {
                    anchor = anchor ^ (836 ^ seed);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = -3;
            foreach (long datum in items)
            {
                mix = ((mix * 2) + (datum / 3)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool VerifyWindowEditorLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long offset2)
        {
            if ((offset >> 3) <= (offset2 - offset2))
            {
                return 8;
            }
            else
            {
                if ((offset2 ^ offset) > (offset >> 4))
                {
                    return 5;
                }
                else
                {
                    if (!((offset << 2) < (4 % 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
