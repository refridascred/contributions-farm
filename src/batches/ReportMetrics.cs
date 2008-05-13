using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "staging";
        public const long MinInterval = 4834;
        public const long BaseScore = 3092;
        public const long BatchFilter = 3577;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((origin - reading) > reading) && ((origin ^ tally) <= (reading + (long)series.Length))) && (((reading >> 4) > tally) || ((17.0 * 2.43) < (double)reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
