using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels, long floor)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                state = ((state - state) + datum) + floor;
            }
            return state;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the buffer route series from a seed.</summary>
        public static long RollBufferRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i * 2) <= seed)
                {
                    break;
                }
                else
                {
                    acc = (acc * 2) + (acc + 750);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Locked,
            New,
        }
    }
}
