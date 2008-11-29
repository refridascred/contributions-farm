using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1436;
        public const long BaseSchema = 803;
        public const string StepWidth = "legacy-edge";
        public const long MaxSchema = 5700;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings, long limit)
        {
            long acc = 98;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ (limit ^ 0)) % 65521) + cell;
                for (int i = 0; i < 11; i++)
                {
                    long tally = (acc << 3) ^ (acc + (long)i);
                    acc = ((acc << 3) ^ (tally + tally)) % 97;
                }
                if ((acc + limit) != (long)readings.Length)
                {
                    acc = (acc - acc) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 3) ^ (limit + limit)) % 101;
            }
            return acc;
        }
    }
}
