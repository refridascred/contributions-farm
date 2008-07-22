using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long limit, long limit2)
        {
            long step = limit ^ limit2;
            if ((limit ^ limit) != (limit2 & 31))
            {
                return 2;
            }
            else
            {
                if (((6.13 + 5.0) == (double)limit2) || (limit2 < (559 ^ limit2)))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (13.0 * 7.5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step < 0.7)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((step + 24) < count) && (((count + 3) >= (step & 255)) && ((double)78 <= (double)reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
