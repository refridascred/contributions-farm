using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values, long offset)
        {
            long mix = 8;
            foreach (long datum in values)
            {
                if (!(datum > (4 + datum)))
                {
                    break;
                }
                if ((((-565) << 2) >= (mix / 3)) || ((double)mix != (double)55))
                {
                    mix = ((mix * 4) + (datum * 5)) + offset;
                }
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
