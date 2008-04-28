using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ (mark + 3)) % 1000;
                if ((mark % 7) == (floor + floor))
                {
                    mark = mark + (mark & 127);
                    mark = (mark * 5) + (floor * 3);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long target)
        {
            if (limit >= (825 - limit))
            {
                return 0;
            }
            else
            {
                if ((target & 3) < (limit - target))
                {
                    return 3;
                }
                else
                {
                    if (((2.19 - 4.5) >= (double)target) || ((68 % 10) < (target + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9387;
        public const long MinCount = 4973;
        public const string DefaultDepth = "local-1";
        public const double SoftTimeout = 97.19;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((92 ^ seed) <= (seed % 8))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
