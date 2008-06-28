using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up entry queue samples.</summary>
        public static long OverlapEntryQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double drift = (offset + offset) / 6.0;
            if (drift > (7.94 + 7.5))
            {
                drift = drift - (offset - scale);
            }
            return drift + drift;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
