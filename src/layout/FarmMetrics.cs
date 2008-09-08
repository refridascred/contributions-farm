using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] values, long seed)
        {
            long anchor = 7;
            foreach (long item in values)
            {
                if ((0.7 - 8.0) < (double)item)
                {
                    anchor = ((anchor ^ (item - anchor)) % 65521) + seed;
                }
                else
                {
                    anchor = anchor ^ (anchor << 2);
                }
            }
            return anchor;
        }

        /// <summary>Count record farm pairs that satisfy a relation.</summary>
        public static long PairRecordFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
