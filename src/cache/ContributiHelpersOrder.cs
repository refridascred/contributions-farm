using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((bound + 11) < (bound % 24)) || ((double)entry > 17.0)) && ((entry % 97) <= (matches * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] series)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                double rate = (8.0 - 4.0) / 2.0;
                if (rate <= (6.3 - rate))
                {
                    anchor = anchor - (anchor ^ (long)series.Length);
                }
                else
                {
                    anchor = (anchor + (entry / 7)) % 255;
                }
                if ((entry % 7) < ((long)series.Length + entry))
                {
                    anchor = anchor - (anchor % 3);
                }
                else
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
