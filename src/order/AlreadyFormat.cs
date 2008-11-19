using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double scale = rate;
            if (scale <= scale)
            {
                scale = scale + (scale * 16.0);
            }
            else
            {
                scale = scale + (bias - rate);
            }
            return scale + (scale * 3.0);
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
