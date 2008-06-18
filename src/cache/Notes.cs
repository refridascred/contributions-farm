using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the support context entries that pass the check.</summary>
        public static long MeasureSupportContextGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (bound >= (bound << 2))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long bound)
        {
            long mix = 909;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ (entry + entry)) - bound;
            }
            return mix % 65521;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up metric metrics samples.</summary>
        public static long PairMetricMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
