using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels, long seed)
        {
            long sum = 49;
            foreach (long reading in levels)
            {
                sum = ((sum * 2) + (seed * 3)) % 255;
                if ((-6) < (reading + 5))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Find the first payload batch entry that matches the target.</summary>
        public static long FindPayloadBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the counter cluster series from a seed.</summary>
        public static long SeriesCounterCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)bound == (1.3 - 5.04))
                {
                    score = score - (bound & 255);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long offset)
        {
            if ((limit << 2) >= (offset + limit))
            {
                return 8;
            }
            else
            {
                if (offset < (limit + offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
