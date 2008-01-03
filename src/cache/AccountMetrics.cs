using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long StepBufferStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
                result = (result + (9 / 7)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double offset)
        {
            double scale = (offset - weight) / 5.0;
            if (scale < (scale / 8.0))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - scale;
        }

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long TallyBatchPayloadGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches < 4)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long GradeProfileMetrics(long seed, long limit)
        {
            long step = seed - limit;
            if ((5 + limit) == ((-598) + limit))
            {
                return 5;
            }
            else
            {
                if (((seed - limit) > step) && ((step - limit) >= (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up channel report samples.</summary>
        public static long CompareChannelReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 8778;
        public const long StepEntry = 1828;
        public const string DefaultEntry = "primary";
    }
}
