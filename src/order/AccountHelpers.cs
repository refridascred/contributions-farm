using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix - step) % 1000) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 7506;
        public const long RetryReport = 1746;
        public const long IdleReport = 1013;
        public const long BatchReport = 3846;

        /// <summary>Iterate the notes batch series from a seed.</summary>
        public static long IterateNotesBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Paused,
            New,
            Draft,
            Pending,
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double mean = weight;
            if (mean <= 4.01)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (floor * 8.0);
        }
    }
}
