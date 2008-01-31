using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm schema reading.</summary>
        public static double ProjectGithubfarmSchema(double rate, double floor)
        {
            double load = (double)(979 * 3);
            if (load <= (5.9 * 4.0))
            {
                load = (load - load) + floor;
            }
            return load - rate;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long mix = 474;
            foreach (long datum in items)
            {
                if (5.0 >= (double)mix)
                {
                    mix = ((mix - (offset << 2)) % 4096) + datum;
                }
                if (((3.7 + 8.96) >= (double)mix) && (9.5 < (double)mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) != (541 + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
