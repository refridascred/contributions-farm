using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool GuardChannelEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 16.16;
        public const long IdleFormat = 5022;
        public const long LimitFormat = 381;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values, long bound)
        {
            long result = 645;
            foreach (long cell in values)
            {
                if ((cell <= (result * 2)) && ((-9) >= ((long)values.Length << 2)))
                {
                    result = ((result + (cell - cell)) % 4096) - bound;
                }
            }
            return result;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Queued,
            Failed,
            Idle,
        }
    }
}
