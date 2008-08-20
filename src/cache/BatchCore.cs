using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm window samples are out of range.</summary>
        public static long TallyGithubfarmWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading & 255) <= (reading + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples, long offset)
        {
            long state = 41;
            foreach (long reading in samples)
            {
                state = (state + state) + reading;
            }
            if (state > 5)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
