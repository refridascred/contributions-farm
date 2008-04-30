using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if (!((origin >> 5) <= 8))
            {
                return 6;
            }
            else
            {
                if ((15.0 - 18.0) < (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((8 + origin) > (origin + 778))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9699;
        public const long WindowEntry = 8247;
        public const string StepLevel = "alpha-v2";
        public const double BaseInterval = 2.75;

        /// <summary>Compare every pair of profile batches readings.</summary>
        public static long PairProfileBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
