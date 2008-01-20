using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((((long)readings.Length >> 5) == (seen * 2)) && ((datum % 3) < (900 >> 4))) && ((bound * 2) != (long)readings.Length))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Match up profile context samples.</summary>
        public static long MatchProfileContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi stats pair into a bucket.</summary>
        public static long ClassifyContributiStats(long floor, long seed)
        {
            if ((-56) >= (floor << 3))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) != (seed + floor)) || ((1.0 + 17.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= (seed + 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 89.67;
        public const string BaseScore = "alpha-1";
        public const long BaseSize = 8865;
        public const string DefaultEditor = "local-edge";
    }
}
