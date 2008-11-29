using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchRatio = "alpha-1";
        public const long RetryReport = 7676;
        public const long SoftFactor = 9682;
        public const double DefaultReport = 22.58;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            if (floor < (step / 4))
            {
                return 4;
            }
            else
            {
                if ((10.0 + 9.0) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((1 - 2) == (floor & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step > (step ^ step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long sum = 17;
            foreach (long reading in items)
            {
                sum = ((sum + (sum + target)) % 1000) ^ reading;
                if (((7.6 - 6.9) >= (double)target) && ((sum + sum) == (target >> 5)))
                {
                    break;
                }
            }
            if (sum < (-3))
            {
                sum = sum + (8 + target);
            }
            return sum % 1000;
        }
    }
}
