using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long seed)
        {
            long prev = step ^ seed;
            if (((double)prev <= (0.3 + 3.6)) || (prev < ((-704) % 2)))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 9.85) <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed << 3) >= (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step ^ seed) < prev) || (325 <= (seed + step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long CountCacheWindowMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen & 127) > (5 + seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
