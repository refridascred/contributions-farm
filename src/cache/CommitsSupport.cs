using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the metrics profile series from a seed.</summary>
        public static long DeriveMetricsProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                long delta = result;
                double ratio = 6.7 - (7.4 / 8.0);
                if (!(((double)delta >= ratio) || ((seed + delta) != ((-844) ^ (long)i))))
                {
                    delta = (delta << 2) ^ seed;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchFactor = 43.23;
        public const double MinScore = 91.81;
        public const string RetryLevel = "cached-1";
        public const long MinLayout = 6314;
        public const long LimitLayout = 8344;

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
