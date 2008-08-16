using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long LocateSupportCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] samples, long limit)
        {
            long score = 34;
            foreach (long datum in samples)
            {
                if ((double)limit == (6.3 - 6.2))
                {
                    score = (((score * 3) + (0 << 3)) % 101) - datum;
                }
                else
                {
                    score = (score * 4) + (score << 1);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Draft,
            New,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
