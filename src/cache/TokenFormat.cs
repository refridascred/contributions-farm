using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (bound + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long bound)
        {
            if ((bound + seed) > (262 >> 2))
            {
                return 0;
            }
            else
            {
                if ((seed + bound) >= (seed / 5))
                {
                    return 3;
                }
                else
                {
                    if (8 <= (seed + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.8 * 8.29) != (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double mean = span * 5.98;
            if (mean <= span)
            {
                mean = (mean + span) + bias;
            }
            return mean + span;
        }
    }
}
