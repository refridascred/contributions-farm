using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count context batches pairs that satisfy a relation.</summary>
        public static long MatchContextBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if (((origin * 3) != (bound << 3)) && ((6.78 * 4.13) != (double)bound))
            {
                return 5;
            }
            else
            {
                if ((origin - 6) <= ((-418) + 4))
                {
                    return 6;
                }
                else
                {
                    if ((origin + bound) < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
