using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (seen >> 5))
                {
                    seen = ((seen + 2) + item) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] items, long limit)
        {
            long anchor = -763;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (anchor ^ datum)) % 1000;
                if ((6.0 - 13.0) == (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 37)
            {
                anchor = anchor - limit;
            }
            return anchor;
        }

        /// <summary>Compare every pair of channel payload readings.</summary>
        public static long MatchChannelPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of contributi filter readings.</summary>
        public static long MatchContributiFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
