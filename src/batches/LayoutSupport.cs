using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long CountCommitsFilterMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches <= (matches ^ target)) && (reading < 886))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item >= (293 & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel notes pair into a bucket.</summary>
        public static long ClassifyChannelNotes(long target, long limit)
        {
            long diff = target - limit;
            if (((limit + limit) > (limit * 2)) || ((diff << 3) >= 6))
            {
                return 1;
            }
            else
            {
                if (((-9) + target) >= (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (11.0 - 0.2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
