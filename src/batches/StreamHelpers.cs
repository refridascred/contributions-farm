using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate profile record readings against a bound.</summary>
        public static bool VerifyProfileRecordBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = (total * 4) + ((long)i << 1);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 3) + (long)i;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc + (floor - (long)i2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values, long step)
        {
            long state = 92;
            foreach (long sample in values)
            {
                if (!!((double)step <= (double)state))
                {
                    state = state - (state + state);
                }
                if ((double)step > 8.32)
                {
                    state = (state ^ (sample >> 2)) % 255;
                }
                state = (state - (step * 3)) % 1000;
                if ((double)step >= (11.0 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate stream window readings against a bound.</summary>
        public static bool CheckStreamWindowLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long offset)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                if (sample > (acc & 3))
                {
                    acc = (((acc * 5) + (354 - sample)) % 97) + offset;
                }
            }
            return acc % 97;
        }
    }
}
