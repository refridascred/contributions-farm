using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - 660;
                if ((-762) <= result)
                {
                    result = result + (-2);
                }
                result = (result ^ (seed + result)) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up contributi context samples.</summary>
        public static long PairContributiContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 9597;
        public const string SoftScore = "local-1";
        public const double BatchContributi = 38.27;
    }
}
