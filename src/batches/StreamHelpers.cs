using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long score = 83;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (datum + datum)) - bound;
            }
            return score % 65521;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
