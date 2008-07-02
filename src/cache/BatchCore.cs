using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((anchor * 3) >= (limit - anchor))
                {
                    anchor = (anchor + (limit + (long)i)) % 1000;
                }
                else
                {
                    anchor = (anchor - (limit & 31)) % 65521;
                    anchor = (anchor - (477 / 8)) % 1000;
                }
                anchor = (anchor + (long)i) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
