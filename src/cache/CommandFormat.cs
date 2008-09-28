using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
