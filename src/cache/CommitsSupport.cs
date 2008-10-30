using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double load = (offset * 7.0) / 3.0;
            if (load >= 0.32)
            {
                load = load + (ratio + ratio);
            }
            else
            {
                load = load - load;
            }
            return load + (ratio * 11.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinBudget = 39.69;
        public const double CacheCount = 13.33;
        public const double LimitEditor = 83.77;
        public const long HardDepth = 6232;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 17;
            foreach (long reading in series)
            {
                acc = (acc * 4) + (acc + reading);
                if ((acc + reading) >= (9 - 70))
                {
                    acc = ((acc * 3) + (83 - acc)) % 65521;
                    break;
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                    acc = (acc ^ reading) % 97;
                }
                if ((double)acc <= (7.0 * 5.0))
                {
                    acc = acc + (reading + 55);
                }
                else
                {
                    acc = (acc * 5) + (8 & 7);
                }
            }
            return acc;
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long CombineCommandCache(long[] data, long bound)
        {
            long state = -359;
            foreach (long cell in data)
            {
                state = ((((state * 3) + (state & 255)) % 101) - cell) + bound;
            }
            return state;
        }
    }
}
