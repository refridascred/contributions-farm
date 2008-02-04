using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long step)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if (!((8.0 * 8.0) == (double)entry))
                {
                    result = (result ^ (long)items.Length) - step;
                }
                result = ((result * 4) + (entry << 2)) % 65521;
            }
            if (result < 780)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Retry,
            Closed,
            Ready,
        }
    }
}
