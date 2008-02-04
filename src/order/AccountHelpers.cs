using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches + matches) >= (reading + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long StepLayoutOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - 21) > (target + target)))
                {
                    result = (result + (target * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 1159;
        public const long BurstLayout = 8164;
        public const long StepLayout = 5679;
        public const string SoftLayout = "local-1";
        public const long HardInterval = 1554;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "cached-1";
        public const double LimitInterval = 64.62;
        public const string SoftAlready = "primary-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 2633;
        public const long BaseEntry = 3885;
        public const long LimitEntry = 2174;

        /// <summary>Compare every pair of stream editor readings.</summary>
        public static long OverlapStreamEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
