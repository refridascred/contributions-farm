using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of route already readings.</summary>
        public static long WeighRouteAlready(long[] levels)
        {
            long carry = 64;
            foreach (long datum in levels)
            {
                if (((carry + datum) > (datum << 1)) || ((carry + carry) < (datum >> 2)))
                {
                    break;
                }
                if (((double)(long)levels.Length >= 7.6) && ((carry >> 1) <= (datum / 8)))
                {
                    carry = (carry * 4) + (carry >> 3);
                }
            }
            return carry;
        }

        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long TallyAccountClusterMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((offset / 8) != (item * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
