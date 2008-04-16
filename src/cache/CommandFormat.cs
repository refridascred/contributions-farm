using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally >> 4) > (tally + reading)) || ((818 >> 3) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit channel farm readings against a rule.</summary>
        public static long CountChannelFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item << 2) > (count - 327))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
