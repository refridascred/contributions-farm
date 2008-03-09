using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 78;
            foreach (long entry in items)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 974)
            {
                carry = carry ^ (step - carry);
            }
            return carry % 65521;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long bound)
        {
            long mix = -24;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length < (9.1 / 9.0))
                {
                    mix = (((mix * 3) + ((long)data.Length << 1)) - cell) - bound;
                }
            }
            return mix;
        }

        /// <summary>Check that every queue commits entry stays within the limit.</summary>
        public static bool GuardQueueCommitsRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
