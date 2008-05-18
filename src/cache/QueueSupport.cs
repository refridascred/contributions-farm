using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count layout entry pairs that satisfy a relation.</summary>
        public static long OverlapLayoutEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value >= (4.64 / 5.0))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultWidth = 62.27;
        public const long SoftAccount = 5324;
        public const long IdleSpan = 5506;
    }
}
