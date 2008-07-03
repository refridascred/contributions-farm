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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
