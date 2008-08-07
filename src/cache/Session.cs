using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + count) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + target) != (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            if (((9.8 - 4.1) != (double)step) && (origin < (1 / 8)))
            {
                return 5;
            }
            else
            {
                if ((6.0 / 8.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step <= origin) && ((step % 60) != (origin * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
