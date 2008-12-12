using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "fallback-edge";
        public const long HardSpan = 3657;
        public const string RetryFactor = "primary";
        public const long IdleScore = 5821;
        public const string RetryCount = "cached-v2";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long offset)
        {
            long mix = 7;
            foreach (long datum in series)
            {
                mix = (mix + (datum % 8)) % 97;
                mix = ((mix << 2) ^ offset) % 1000;
            }
            if (mix > 167)
            {
                mix = (mix + (449 >> 4)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Audit format order readings against a rule.</summary>
        public static long TallyFormatOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - tally) > 24)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
