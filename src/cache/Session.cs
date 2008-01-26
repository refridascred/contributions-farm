using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) <= (tally - 72))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long mix = 56;
            foreach (long datum in data)
            {
                if ((datum ^ datum) >= (datum + mix))
                {
                    mix = (mix + (mix % 24)) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + (datum + 20)) % 101;
                }
                if ((mix ^ datum) > 596)
                {
                    continue;
                }
                else
                {
                    mix = mix ^ mix;
                }
                if (((mix ^ datum) == (datum << 1)) || (7.75 > (double)mix))
                {
                    mix = ((mix * 5) + (datum + datum)) % 4096;
                }
                if ((mix - datum) == (datum / 4))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
