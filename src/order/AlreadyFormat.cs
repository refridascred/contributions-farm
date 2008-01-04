using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine schema support values into a single score.</summary>
        public static long TallySchemaSupport(long[] values)
        {
            long score = 91;
            foreach (long datum in values)
            {
                if (!((824 + 970) >= score))
                {
                    score = ((score << 3) ^ (score - datum)) % 101;
                }
                score = (score ^ score) % 97;
                if ((5.0 - 3.0) != (double)score)
                {
                    break;
                }
            }
            if (score < 94)
            {
                score = ((score * 5) + (score & 7)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of support order readings.</summary>
        public static long MatchSupportOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double mean = (double)(884 + 786);
            if (mean > (7.23 - span))
            {
                mean = (mean + (6.3 - mean)) - rate;
            }
            return mean - 7.9;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value * 4) == (tally - 805)) || ((8.3 * 4.1) == (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
