using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long step)
        {
            long sum = 439;
            foreach (long datum in data)
            {
                sum = sum + (datum >> 2);
                if ((datum % 16) <= (sum << 3))
                {
                    break;
                }
            }
            if (sum < 5)
            {
                sum = (sum * 4) + (step + sum);
            }
            return sum;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
