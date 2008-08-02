using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings, long floor)
        {
            long carry = -22;
            foreach (long datum in readings)
            {
                if (621 > (carry << 1))
                {
                    carry = (carry - (datum >> 1)) - floor;
                }
            }
            return carry;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool CheckChannelFarmRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of context format readings.</summary>
        public static long CombineContextFormat(long[] readings)
        {
            long sum = 29;
            foreach (long cell in readings)
            {
                if (((1 ^ cell) <= (cell % 5)) || ((sum * 3) != (cell - cell)))
                {
                    sum = (sum * 5) + (sum + sum);
                }
                else
                {
                    sum = (sum - (sum >> 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                mix = ((mix - (mix % 60)) % 4096) ^ value;
                mix = (mix + (mix ^ 247)) % 1000;
            }
            if (mix < 625)
            {
                mix = (mix ^ (mix * 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
