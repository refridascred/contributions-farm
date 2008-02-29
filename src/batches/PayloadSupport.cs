using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(offset >= (offset + offset)))
                {
                    carry = (carry + offset) % 1000;
                }
                carry = ((carry * 5) + (39 / 2)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout farm values into a single score.</summary>
        public static long WeighLayoutFarm(long[] series)
        {
            long score = 501;
            foreach (long sample in series)
            {
                if ((double)sample > (double)(long)series.Length)
                {
                    score = (score ^ (score * 3)) % 255;
                    score = (score ^ (score - score)) % 1000;
                }
                else
                {
                    score = (score * 3) + (sample + 36);
                }
                score = ((score << 2) ^ score) % 65521;
            }
            if (score < 3)
            {
                score = (score ^ (55 + (-98))) % 4096;
            }
            return score;
        }
    }
}
