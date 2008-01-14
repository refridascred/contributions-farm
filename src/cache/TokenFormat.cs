using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(tally <= (entry << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "standard-1";
        public const long LimitTimeout = 9010;
        public const long BaseEntry = 87;
        public const string BatchEntry = "staging-v2";
        public const double BurstScore = 69.48;

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double load = weight - (double)54;
            if (load <= (double)693)
            {
                load = load + offset;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - 9.44;
        }
    }
}
