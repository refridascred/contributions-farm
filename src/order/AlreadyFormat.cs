using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 66;
            foreach (long cell in samples)
            {
                mix = mix ^ (314 ^ 55);
                if (cell >= mix)
                {
                    mix = (mix - 8) % 65521;
                }
                if ((cell / 4) <= (cell ^ cell))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Queued,
            Failed,
            Stale,
            Paused,
        }
    }
}
