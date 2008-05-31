using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Locked,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long offset)
        {
            long carry = 32;
            foreach (long datum in samples)
            {
                carry = (((carry << 3) ^ carry) ^ datum) - offset;
            }
            return carry;
        }

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool GuardStreamProfileLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "cached-edge";
        public const string HardSize = "open-edge";
        public const long MaxCount = 1377;
        public const long StepWidth = 9229;
    }
}
