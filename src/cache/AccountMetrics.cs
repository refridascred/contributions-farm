using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 2820;
        public const long BaseStats = 3248;
        public const long MinSize = 2390;

        /// <summary>Audit buffer commits readings against a rule.</summary>
        public static long AuditBufferCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value < (count % 7)) && (((double)count >= (5.2 + 8.16)) || ((double)count < (1.0 + 15.0))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 118;
            foreach (long datum in levels)
            {
                if ((datum + total) < total)
                {
                    total = (total * 4) + ((long)levels.Length + total);
                }
                else
                {
                    total = (total << 2) ^ ((long)levels.Length >> 3);
                }
                if (((total / 4) != (total >> 2)) && (datum <= (total >> 2)))
                {
                    break;
                }
            }
            if (total > 39)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if (((bound2 + bound) <= (bound - seed)) && ((4 + bound) >= bound2))
            {
                return 5;
            }
            else
            {
                if (!(bound < (bound % 7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < 19.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
