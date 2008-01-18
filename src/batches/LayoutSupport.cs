using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally ^ reading) >= (bound - bound)) || ((tally > (bound - bound)) && ((bound & 255) <= (bound % 64))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the contributi already entries that pass the check.</summary>
        public static long TallyContributiAlreadyMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((3.0 + 6.4) <= (double)cell) || (((cell ^ (long)readings.Length) <= 54) || ((double)matches >= (18.0 - 20.0))))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }
    }
}
