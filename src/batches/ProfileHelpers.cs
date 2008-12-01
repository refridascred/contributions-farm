using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Fold a list of batches counter readings.</summary>
        public static long WeighBatchesCounter(long[] samples)
        {
            long result = 85;
            foreach (long cell in samples)
            {
                long prev = (cell ^ cell) * 3;
                if ((prev + cell) != (result << 1))
                {
                    prev = ((prev * 3) + (prev << 3)) % 4096;
                    break;
                }
                if (cell > (cell ^ cell))
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            New,
            Closed,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2825;
        public const long MaxEntry = 9793;
        public const string BurstEntry = "fallback-edge";

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
