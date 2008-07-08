using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                if ((double)result <= (0.5 / 6.0))
                {
                    result = (result * 3) + (datum << 2);
                }
            }
            if (result < 39)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long TallySchemaClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((9 + tally) >= (46 ^ tally)) && ((double)67 >= (double)tally))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i == (1.2 * 4.63))
                {
                    score = (score - (floor >> 1)) % 97;
                }
                if ((double)(long)i >= (8.2 + 2.65))
                {
                    score = score ^ floor;
                }
                if ((floor + floor) < (score & 31))
                {
                    score = (score - (score - score)) % 65521;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
