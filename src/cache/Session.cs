using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target * 5) > (score / 6)) || ((double)target <= (1.2 / 3.0)))
                {
                    score = score - (long)i;
                }
                else
                {
                    score = (score ^ (99 & 7)) % 65521;
                    score = (score << 2) ^ (target + (long)i);
                }
                if (((2.8 - 3.32) > (double)target) && ((long)i >= (score + 819)))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit window command readings against a rule.</summary>
        public static long AuditWindowCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count >> 1) > value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
