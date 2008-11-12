using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long bound)
        {
            if ((double)seed < (1.3 + 6.07))
            {
                return 4;
            }
            else
            {
                if (!((double)bound >= (7.0 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long FoldClusterBuffer(long[] series, long target)
        {
            long result = -177;
            foreach (long value in series)
            {
                if (value < target)
                {
                    result = (result + (6 >> 4)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Audit farm command readings against a rule.</summary>
        public static long AuditFarmCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length < (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
