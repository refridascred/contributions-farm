using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item >> 3) <= (item << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long seed)
        {
            long acc = 362;
            foreach (long entry in readings)
            {
                if ((20 / 6) > (entry & 255))
                {
                    acc = (((acc * 4) + (acc >> 1)) % 1000) - seed;
                }
            }
            return acc;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
