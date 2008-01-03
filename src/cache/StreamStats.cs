using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits <= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long bound)
        {
            long total = 48;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (((total * 5) + total) ^ (long)i) - entry;
                }
                total = (total - bound) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long anchor = 22;
            foreach (long item in samples)
            {
                if (716 >= (item % 3))
                {
                    anchor = anchor ^ ((long)samples.Length / 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Failed,
            Dropped,
            Done,
        }
    }
}
