using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool ValidateReportMetricsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema profile input into a small class.</summary>
        public static long ClassifySchemaProfile(long seed, long limit)
        {
            long edge = seed + limit;
            if ((limit << 3) == (seed - limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 8.3)
                {
                    return 6;
                }
                else
                {
                    if ((15.0 + 1.97) > (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long seed)
        {
            long lane = limit ^ seed;
            if ((lane ^ seed) != (limit % 7))
            {
                return 3;
            }
            else
            {
                if ((0.83 * 7.0) != (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((8 >> 4) <= seed) || ((8.0 * 18.0) >= (double)seed))
                    {
                        return 8;
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
