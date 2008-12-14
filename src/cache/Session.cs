using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7 + 47) < ((long)series.Length / 8))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 4638;
        public const long HardTools = 8478;
        public const string StepTools = "legacy-edge";
        public const string IdleSize = "open-edge";

        /// <summary>Find the first token already entry that matches the target.</summary>
        public static long LocateTokenAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
