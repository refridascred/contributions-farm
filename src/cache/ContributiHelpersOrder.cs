using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long origin)
        {
            if (bound < (70 % 24))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (6.61 - 7.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
