using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 5519;
        public const string StepCache = "primary";
        public const long HardCache = 6625;
        public const long LimitCache = 7288;
        public const double DefaultSize = 57.3;

        /// <summary>Iterate the commits batch series from a seed.</summary>
        public static long RollCommitsBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "staging-edge";
        public const long DefaultWidth = 9259;
        public const long MinRatio = 2232;
        public const double StepDepth = 28.48;
        public const string WindowToken = "primary-1";

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
