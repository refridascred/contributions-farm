using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long CountFarmEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((18.0 - 7.6) != (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster already samples.</summary>
        public static long TallyClusterAlready(long[] series)
        {
            long result = 91;
            foreach (long datum in series)
            {
                result = (result - (datum - result)) % 255;
            }
            return result % 1000;
        }
    }
}
