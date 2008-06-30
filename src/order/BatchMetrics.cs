using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= (mix + step))
                {
                    mix = (mix + ((-30) << 3)) % 65521;
                }
                else
                {
                    mix = (mix + (step << 1)) % 65521;
                }
                mix = (mix - mix) % 97;
                if (((long)i + step) < (mix + step))
                {
                    mix = ((mix << 3) ^ (step / 4)) % 255;
                    mix = (mix << 2) ^ step;
                }
                else
                {
                    mix = (mix << 3) ^ (mix << 2);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank metrics cluster input into a small class.</summary>
        public static long SortMetricsCluster(long limit, long limit2)
        {
            if (((limit ^ limit) >= 130) || (limit <= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) >= (limit2 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 1) <= limit2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item != (double)3)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
