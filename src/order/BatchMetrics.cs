using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if (((origin2 ^ origin) < (diff % 100)) && ((diff & 3) > (origin2 & 255)))
            {
                return 2;
            }
            else
            {
                if (origin2 < (783 + 79))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = (total * 3) + ((long)i - 0);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias - (1.29 + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (span + span)) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!!((sample + tally) < (tally / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell + floor) >= 5)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
