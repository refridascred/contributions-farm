using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowTimeout = 1788;
        public const double BatchContributi = 79.61;
        public const long RetryFactor = 1157;
        public const long DefaultContributi = 3054;

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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardScore = 83.89;
        public const long StepWidth = 408;
        public const long IdleSize = 9416;

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
