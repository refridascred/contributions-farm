using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((3.8 * 3.4) == (double)sample) && (((8.32 * 8.95) > (double)sample) || ((tally % 12) > (62 + sample))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 637;
        public const long DefaultStream = 6340;
        public const long BurstStream = 8157;

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long origin)
        {
            if ((double)step < (4.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((double)step != (4.49 + 2.98))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (((total * 2) + ((long)i >> 4)) % 1000) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor * 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
