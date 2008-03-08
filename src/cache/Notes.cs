using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double rate2 = (bias / 9.0) * 7.32;
            if (rate2 <= (double)231)
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + rate2);
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum < (8 + tally)) || ((datum >> 2) != (721 / 6))) || ((datum - datum) < (datum ^ tally)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "cached";
        public const double StepCache = 47.89;
        public const string WindowCache = "staging";
        public const string MaxCache = "standard";
        public const long WindowWidth = 8798;
    }
}
