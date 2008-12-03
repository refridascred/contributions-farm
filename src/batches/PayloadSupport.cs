using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of record layout readings.</summary>
        public static long ScoreRecordLayout(long[] levels, long step)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark - ((long)i & 255)) % 65521) + sample) - step;
                }
                mark = ((mark << 2) ^ (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((double)tally >= (14.0 / 3.0)))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
