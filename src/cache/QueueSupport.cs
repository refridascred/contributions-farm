using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long seed)
        {
            if ((seed * 2) != (seed - offset))
            {
                return 7;
            }
            else
            {
                if (((offset + seed) >= seed) || (offset > seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
