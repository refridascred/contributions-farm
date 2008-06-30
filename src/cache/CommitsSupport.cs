using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the layout farm entries that pass the check.</summary>
        public static long MeasureLayoutFarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (685 <= (hits << 3))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account format entries.</summary>
        public static long FoldAccountFormat(long[] series)
        {
            long mark = 4;
            foreach (long item in series)
            {
                mark = mark - (item % 60);
                if (((item & 31) >= 94) && ((mark >> 3) == (8 << 2)))
                {
                    mark = (mark + (8 + mark)) % 65521;
                }
                if ((mark - (-641)) < item)
                {
                    break;
                }
            }
            if (mark < 570)
            {
                mark = mark ^ ((long)series.Length / 5);
            }
            return mark % 4096;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)bound == (2.8 / 3.0))
            {
                return 1;
            }
            else
            {
                if (!((double)span > (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((73 + span) >= (bound << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (20.0 <= (double)span)
                        {
                            return 3;
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
}
