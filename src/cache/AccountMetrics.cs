using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 10.87;
        public const double StepTools = 25.03;
        public const string BatchLevel = "primary-v2";

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((limit > 556) && (5 < (limit >> 3)))
            {
                return 0;
            }
            else
            {
                if (((8 ^ offset) > (span % 100)) && ((double)limit >= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!(offset <= (offset / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a entry cache counter forward.</summary>
        public static long SeriesEntryCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((carry < (carry << 1)) || ((floor / 8) >= ((long)i & 127)))
                {
                    carry = ((carry << 3) ^ 7) % 1000;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit order entry readings against a rule.</summary>
        public static long TallyOrderEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading >= (reading ^ tally)) || ((tally - 60) <= (reading * 3))) && ((((long)series.Length * 4) > (tally % 97)) || ((6 & 127) == (582 - tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
