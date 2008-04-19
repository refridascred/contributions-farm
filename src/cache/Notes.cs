using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "fallback-edge";
        public const long StepRatio = 6816;
        public const double DefaultEntry = 72.4;
        public const long IdleEntry = 1263;
        public const double RetryEntry = 85.49;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long limit2)
        {
            long delta = limit - limit2;
            if (((limit2 + limit) != (delta + limit)) || ((61 * 3) > delta))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (16.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((606 * 3) <= (delta & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit2 > limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double weight = (9.0 - offset) + (bias + 7.9);
            if (weight < (double)5)
            {
                weight = weight + (offset * 19.0);
            }
            return weight - bias;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long CountLayoutChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= seen)
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
    }
}
