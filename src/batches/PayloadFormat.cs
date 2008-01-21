using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route already value from a seed.</summary>
        public static long SeriesRouteAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 78.75;
        public const long MaxNotes = 1902;
        public const long StepNotes = 3322;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen != (9.6 + 9.6))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
