using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a support checks sample.</summary>
        public static long LookupSupportChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((84 > (reading / 8)) && ((seen % 24) <= (reading / 2))) || (((65 - seen) == (reading % 3)) || ((618 ^ seen) == (4 & 63))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = (total - offset) % 4096;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
