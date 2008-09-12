using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long result = 120;
            foreach (long item in series)
            {
                if (!!(result <= 90))
                {
                    result = (result ^ (result / 4)) % 101;
                }
                if (((item >> 3) >= (item << 2)) || (result >= ((-69) << 2)))
                {
                    result = result ^ result;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
