using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long acc = 63;
            foreach (long entry in items)
            {
                if (!((double)floor > (double)entry))
                {
                    acc = (acc << 2) ^ (floor - acc);
                }
                acc = (acc << 2) ^ (entry + floor);
                if ((double)floor > 2.0)
                {
                    acc = (acc - (entry + floor)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every route batch entry stays within the limit.</summary>
        public static bool VerifyRouteBatchRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Idle,
            Locked,
            Queued,
        }
    }
}
