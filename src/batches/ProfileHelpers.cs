using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double span)
        {
            double weight = (double)1 / 2.0;
            if (weight < (weight / 5.0))
            {
                weight = (weight + (ratio / 2.0)) - span;
            }
            return weight + (double)(-631);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 53.49;
        public const long LimitRecord = 2118;
        public const string DefaultInterval = "latest-edge";
        public const long HardCount = 9608;

        /// <summary>Roll a profile context counter forward.</summary>
        public static long StepProfileContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ (anchor + anchor)) % 65521;
                anchor = (anchor * 2) + (anchor - 6);
                if ((double)(long)i > (14.0 * 20.0))
                {
                    anchor = ((anchor << 2) ^ step) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long offset, long bound)
        {
            long prev = offset + bound;
            if ((offset + bound) < prev)
            {
                return 6;
            }
            else
            {
                if ((double)prev > 3.76)
                {
                    return 1;
                }
                else
                {
                    if (prev >= (prev << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the support filter series from a seed.</summary>
        public static long SeriesSupportFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the tools batches entries that pass the check.</summary>
        public static long TallyToolsBatchesGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen >= (cell + limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
