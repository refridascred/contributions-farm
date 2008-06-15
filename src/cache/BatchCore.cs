using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a metrics checks value against two limits.</summary>
        public static long GradeMetricsChecks(long offset, long limit)
        {
            long delta = offset ^ limit;
            if ((double)offset <= (double)delta)
            {
                return 2;
            }
            else
            {
                if ((offset >= (-8)) || (limit > (delta << 3)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (1.0 * 0.9))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit >> 2) != (944 - 956)) || ((limit ^ delta) >= (limit + delta)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long target)
        {
            long result = 509;
            foreach (long datum in readings)
            {
                if (target >= (datum << 3))
                {
                    result = (result + (target ^ target)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up commits githubfarm samples.</summary>
        public static long PairCommitsGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
