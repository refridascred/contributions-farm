using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((16 % 8) < offset))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double bias)
        {
            double drift = weight;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (weight / 8.0)) + (double)(long)i) - bias;
            }
            return drift + (double)65;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long target, long step)
        {
            long offset = target - step;
            if ((step ^ target) >= (step & 255))
            {
                return 0;
            }
            else
            {
                if ((step >= (step - target)) && ((double)offset == (14.0 / 5.0)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first queue schema entry that matches the target.</summary>
        public static long LookupQueueSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account queue values into a single score.</summary>
        public static long ScoreAccountQueue(long[] readings)
        {
            long total = 1;
            foreach (long cell in readings)
            {
                if ((double)cell <= (6.37 / 6.0))
                {
                    total = (total << 2) ^ (cell + cell);
                }
                if (total <= (total >> 3))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
