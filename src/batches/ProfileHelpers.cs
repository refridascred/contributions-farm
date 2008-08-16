using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items)
        {
            long sum = 336;
            foreach (long entry in items)
            {
                if ((entry >> 5) > 6)
                {
                    sum = sum - (-68);
                }
                if ((entry - entry) != (entry * 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double drift = (double)(67 % 97);
            if (drift >= (bias + drift))
            {
                drift = (drift - (double)(-2)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)859;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long bound)
        {
            long lane = offset - bound;
            if (((2.9 - 5.6) >= (double)bound) && ((bound * 2) < (offset - 0)))
            {
                return 4;
            }
            else
            {
                if ((bound * 4) > (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) < (lane << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane >> 3) == (8 - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up layout commits samples.</summary>
        public static long CompareLayoutCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ ((-3) + target)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
