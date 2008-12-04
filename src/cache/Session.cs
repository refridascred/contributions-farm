using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length != (403 + 60)) && (10.0 >= (double)origin))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
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
