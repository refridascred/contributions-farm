using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < (0 >> 1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long origin)
        {
            long gap = target + origin;
            if ((gap >= (origin / 5)) || ((721 - 6) < (target + origin)))
            {
                return 8;
            }
            else
            {
                if (!((199 - origin) <= gap))
                {
                    return 4;
                }
                else
                {
                    if ((2 - gap) == (target + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long origin)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                if ((double)reading <= 11.0)
                {
                    result = (result << 3) ^ origin;
                }
            }
            return result % 4096;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 5) + bound;
                score = (score ^ score) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Ready,
            Pending,
        }
    }
}
