using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Ready,
            Paused,
            New,
        }

        /// <summary>Audit session tools readings against a rule.</summary>
        public static long TallySessionToolsHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample >= (count + sample))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
