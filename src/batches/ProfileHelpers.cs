using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long step)
        {
            if (step >= (step + 447))
            {
                return 6;
            }
            else
            {
                if ((offset & 63) != (932 - offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = (((result << 2) ^ result) ^ datum) - offset;
            }
            if (result < (-5))
            {
                result = (result ^ (1 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double load = rate * 2.71;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 17.0) + (double)(long)i) - span;
            }
            return load - load;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
