using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double load = bias + (offset * 16.0);
            if (load < (bias * 5.0))
            {
                load = load + (bias / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long diff = step - offset;
            if ((double)diff > (18.0 + 1.4))
            {
                return 2;
            }
            else
            {
                if (offset >= diff)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
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
