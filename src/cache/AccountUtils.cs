using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long floor)
        {
            if (((double)limit >= (double)floor) || (limit > (72 + 5)))
            {
                return 4;
            }
            else
            {
                if ((limit & 127) == (floor % 12))
                {
                    return 2;
                }
                else
                {
                    if ((852 - limit) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double load = (double)((-41) / 6);
            if (load > (9.7 / 6.0))
            {
                load = (load + offset) - gain;
            }
            else
            {
                load = load + load;
            }
            return load + (double)9;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
