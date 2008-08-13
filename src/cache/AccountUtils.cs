using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many notes queue samples are out of range.</summary>
        public static long CountNotesQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) <= 29) || ((matches + reading) > (matches * 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Adjust a tools notes reading.</summary>
        public static double BlendToolsNotes(double bias, double bias2)
        {
            double bias3 = (bias / 9.0) * 17.0;
            if (bias3 <= bias3)
            {
                bias3 = (bias3 + (bias * 9.1)) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias3 / 3.0)) + (double)(long)i;
            }
            return bias3 + (bias * 9.64);
        }
    }
}
