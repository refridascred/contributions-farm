using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = total ^ (9 ^ target);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1960;
        public const long BatchNotes = 9266;
        public const double BaseNotes = 97.84;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((seed % 97) <= 612)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
