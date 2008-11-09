using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((289 ^ count) >= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                if ((19.0 - 4.1) != (double)step)
                {
                    anchor = ((anchor - ((long)data.Length & 255)) % 65521) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
