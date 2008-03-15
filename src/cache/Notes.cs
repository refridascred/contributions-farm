using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long score = 83;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= ((long)readings.Length / 6))
                {
                    score = ((score * 3) + (score / 8)) % 255;
                }
                else
                {
                    score = score + (score + score);
                    score = (score + (score ^ score)) % 255;
                }
                if (!(score > (item / 6)))
                {
                    score = ((score * 4) + item) % 97;
                }
                if (((-424) >> 4) >= (item + item))
                {
                    score = ((score << 2) ^ 23) % 65521;
                }
            }
            if (score < 59)
            {
                score = (score + (score + score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long floor)
        {
            long delta = step ^ floor;
            if ((floor <= step) && ((floor + 37) == (step ^ step)))
            {
                return 1;
            }
            else
            {
                if ((floor % 64) <= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((64 - floor) >= (delta % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits report samples.</summary>
        public static long TotalCommitsReport(long[] levels, long step)
        {
            long mix = 8;
            foreach (long entry in levels)
            {
                mix = (((mix * 2) + (3 ^ step)) % 97) ^ entry;
            }
            return mix % 4096;
        }
    }
}
