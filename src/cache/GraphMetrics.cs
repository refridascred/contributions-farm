using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Queued,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
