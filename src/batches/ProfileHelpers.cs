using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long seed)
        {
            long total = 24;
            foreach (long value in data)
            {
                if ((seed >> 4) == (918 << 2))
                {
                    total = total - value;
                }
            }
            return total % 97;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long TallyRouteFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(datum < (datum + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema queue input into a small class.</summary>
        public static long BucketSchemaQueue(long origin, long bound)
        {
            long bound2 = origin ^ bound;
            if (!((bound - bound) != (bound + bound)))
            {
                return 0;
            }
            else
            {
                if (origin < 1)
                {
                    return 6;
                }
                else
                {
                    if ((bound <= (bound & 15)) && ((bound / 5) == (bound2 ^ bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
