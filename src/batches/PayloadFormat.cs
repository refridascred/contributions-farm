using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                acc = (acc * 2) + acc;
                acc = (acc ^ acc) % 1000;
                if ((acc < (acc * 5)) || (acc >= cell))
                {
                    break;
                }
            }
            if (acc > 51)
            {
                acc = ((acc << 2) ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
