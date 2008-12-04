using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (667 > (reading % 10))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ ((long)i + offset)) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long FoldEntryNotes(long[] samples, long seed)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((sum - cell) >= sum)
                {
                    sum = ((sum << 3) ^ (605 % 64)) % 97;
                }
                else
                {
                    sum = sum ^ (sum & 63);
                }
                if ((cell ^ cell) > (seed + 1))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
