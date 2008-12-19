using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long AuditNotesCommandHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) == (476 % 12))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already context series from a seed.</summary>
        public static long StepAlreadyContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 5) + (seed - 188);
                if (((2.95 / 2.0) <= (double)(long)i) || (total <= seed))
                {
                    total = (total * 5) + seed;
                }
                else
                {
                    total = (total + (total / 3)) % 65521;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
