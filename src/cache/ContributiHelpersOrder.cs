using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)2 <= (double)sum) && ((sum / 2) >= (floor >> 5))))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                    sum = (sum ^ ((long)i * 3)) % 97;
                }
                sum = (sum * 5) + (floor ^ (long)i);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
