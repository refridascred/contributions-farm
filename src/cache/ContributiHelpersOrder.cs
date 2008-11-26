using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample > (92 ^ 474))
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

        /// <summary>Iterate the command stats series from a seed.</summary>
        public static long StepCommandStats(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (target - target)) % 1000;
                if (((double)target < (5.5 - 9.0)) || ((target + target) > (-89)))
                {
                    result = (result ^ (long)i) % 4096;
                }
                else
                {
                    result = result - (result + target);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ (80 >> 2);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
