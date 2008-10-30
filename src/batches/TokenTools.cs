using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long AuditRecordContributiHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((floor - (long)values.Length) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long floor)
        {
            if (((double)offset < (8.0 - 4.0)) || ((floor + offset) == (offset << 1)))
            {
                return 5;
            }
            else
            {
                if ((floor - offset) < (offset % 60))
                {
                    return 8;
                }
                else
                {
                    if (offset <= (floor % 100))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
