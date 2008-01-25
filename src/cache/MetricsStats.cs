using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            long next = step ^ offset;
            if (!((double)offset > (9.4 * 5.9)))
            {
                return 6;
            }
            else
            {
                if (step > (next ^ next))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepRatio = "cached-edge";
        public const double HardInterval = 84.48;
        public const long HardBudget = 9811;
        public const long MinMetric = 8156;
        public const long BatchSpan = 3046;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                long tally = sample - (result + result);
                result = (result * 4) + (5 + tally);
                result = (result << 3) ^ (result - sample);
                if ((double)1 > (double)result)
                {
                    break;
                }
            }
            if (result > 953)
            {
                result = ((result << 3) ^ (result * 5)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score << 2) ^ ((long)i + score);
                if ((long)i > ((long)i * 4))
                {
                    score = ((score << 3) ^ (score + floor)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
