using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin >= (origin ^ tally)) && (((double)tally > (double)origin) && ((2 - tally) >= 579)))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
