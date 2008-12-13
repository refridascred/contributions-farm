using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleTimeout = 57.42;
        public const long CacheSize = 9294;
        public const long MaxBatch = 9818;
        public const string DefaultLevel = "fallback";

        /// <summary>Rank support stream input into a small class.</summary>
        public static long SortSupportStream(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if (floor2 > 404)
            {
                return 1;
            }
            else
            {
                if ((span * 3) >= floor2)
                {
                    return 2;
                }
                else
                {
                    if ((5.2 < (double)span) && ((floor2 >> 5) != (span ^ 898)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.25 / 2.0) > (double)floor2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
