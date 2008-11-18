using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double WindowDepth = 59.6;
        public const long SoftAlready = 8119;
        public const long StepAlready = 726;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = -5;
            foreach (long entry in data)
            {
                if ((sum / 4) > (entry + 6))
                {
                    sum = sum ^ (sum % 64);
                }
                if ((entry - sum) <= entry)
                {
                    sum = ((sum * 2) + (85 / 6)) % 255;
                }
                if ((entry ^ entry) > (sum & 15))
                {
                    sum = ((sum * 2) + 8) % 255;
                }
                else
                {
                    sum = (sum * 2) + (entry << 2);
                }
            }
            return sum;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor + floor) <= carry)
                {
                    break;
                }
                carry = (carry << 3) ^ (floor + carry);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the batch farm series from a seed.</summary>
        public static long StepBatchFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
