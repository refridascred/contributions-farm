using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long step)
        {
            long state = 3;
            foreach (long datum in data)
            {
                if ((state / 2) >= step)
                {
                    state = (state + (2 * 5)) % 4096;
                    state = state ^ (datum + (-56));
                    break;
                }
                state = (state + state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            New,
            Active,
        }
    }
}
