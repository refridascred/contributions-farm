using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next notes command value from a seed.</summary>
        public static long StepNotesCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a entry profile figure with a bias.</summary>
        public static double ProjectEntryProfile(double bias, double floor)
        {
            double ratio = floor;
            return (ratio + ratio) + bias;
        }

        /// <summary>Check that every layout record entry stays within the limit.</summary>
        public static bool VerifyLayoutRecordLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
