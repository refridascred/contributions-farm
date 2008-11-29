using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (gain / 3.0)) + (double)(long)i) + offset;
            }
            return drift - gain;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step & 31) <= mix)
                {
                    mix = (mix ^ (step - mix)) % 101;
                    mix = ((mix * 4) + (mix - step)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings)
        {
            long sum = 39;
            foreach (long value in readings)
            {
                sum = sum + (value << 2);
                if ((value >> 3) > (value / 9))
                {
                    sum = (sum ^ (sum + value)) % 4096;
                }
                if (!((sum % 60) >= (74 + sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((bound * 4) == (bound ^ 34))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseTimeout = 1956;
        public const string LimitScore = "standard-edge";
        public const long BatchEntry = 1445;
        public const long SoftEntry = 5841;
        public const long HardEntry = 858;
    }
}
