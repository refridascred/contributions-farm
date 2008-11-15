using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long seed)
        {
            long state = 42;
            foreach (long item in samples)
            {
                if (!((item << 3) < state))
                {
                    state = ((state * 4) + (state / 8)) % 4096;
                    continue;
                }
                if ((96 >> 5) == (item << 1))
                {
                    state = (state - (seed << 3)) % 65521;
                }
            }
            if (state > 36)
            {
                state = ((state * 5) + (seed - seed)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Paused,
            Synced,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Done,
            Idle,
            Pending,
            Failed,
        }
    }
}
