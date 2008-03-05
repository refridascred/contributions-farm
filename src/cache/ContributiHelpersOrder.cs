using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((505 + matches) == (matches + item))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
