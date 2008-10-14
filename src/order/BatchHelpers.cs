using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 296;
            foreach (long sample in series)
            {
                if ((mix + mix) <= mix)
                {
                    mix = ((mix - (0 << 3)) % 97) + sample;
                }
            }
            return mix;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor + 9) == (1 + 7))
                {
                    carry = ((carry * 2) + (long)i) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long sum = 442;
            foreach (long sample in data)
            {
                sum = (sum ^ (sum % 100)) % 255;
                if (((sum + (long)data.Length) == (sample << 3)) && ((12.0 - 4.3) != (double)sum))
                {
                    break;
                }
            }
            if (sum < (-10))
            {
                sum = (sum * 4) + (sum - sum);
            }
            return sum;
        }
    }
}
