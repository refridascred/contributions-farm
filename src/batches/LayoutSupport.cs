using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a account payload value against two limits.</summary>
        public static long RankAccountPayload(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (((double)limit >= (14.0 - 9.0)) || ((6.49 + 3.0) < (double)prev))
            {
                return 5;
            }
            else
            {
                if (!(prev >= (8 >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - limit) != (prev - (-25)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((prev & 3) >= (prev >> 3)) && (1.6 <= (double)limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (44 <= (entry << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Dropped,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if ((offset + 40) >= offset)
            {
                return 8;
            }
            else
            {
                if ((264 >> 2) < offset2)
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
        }
    }
}
