using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 41;
            foreach (long entry in items)
            {
                if (result > (9 ^ result))
                {
                    result = ((result ^ result) % 97) ^ entry;
                }
            }
            if (result < 565)
            {
                result = ((result * 5) + (result - 29)) % 65521;
            }
            return result;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (double)748)
            {
                drift = drift - (double)(-37);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (2.0 - scale);
        }
    }
}
