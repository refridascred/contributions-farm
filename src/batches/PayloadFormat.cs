using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 385;
        public const double DefaultBudget = 10.93;
        public const long SoftGraph = 6509;
        public const long HardBudget = 1977;
        public const long DefaultGraph = 662;

        /// <summary>Roll a githubfarm layout counter forward.</summary>
        public static long IterateGithubfarmLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step & 1) != (step - step))
                {
                    sum = ((sum * 4) + (123 - step)) % 97;
                    sum = (sum ^ (64 >> 3)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the batches checks entries that pass the check.</summary>
        public static long TallyBatchesChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) != (long)data.Length)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] items)
        {
            long mix = 732;
            foreach (long datum in items)
            {
                if (mix >= (long)items.Length)
                {
                    mix = (((mix * 4) + ((long)items.Length ^ mix)) % 4096) ^ datum;
                }
            }
            return mix % 1000;
        }
    }
}
