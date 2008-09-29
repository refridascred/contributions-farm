using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= 9.0)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long limit)
        {
            long gap = bound - limit;
            if (!((double)gap > 4.65))
            {
                return 6;
            }
            else
            {
                if (((limit - limit) >= limit) && ((gap + (-58)) <= 383))
                {
                    return 3;
                }
                else
                {
                    if ((gap / 8) <= (gap + 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (0.03 >= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((sample << 1) >= 62) || ((double)sample >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
