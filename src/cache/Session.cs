using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < 8.7)
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

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                state = ((((state << 3) ^ state) % 1000) + entry) + origin;
            }
            return state;
        }

        /// <summary>Blend two stats command measurements.</summary>
        public static double ProjectStatsCommand(double weight, double offset)
        {
            double bias = (weight * 9.0) - weight;
            if (bias < (offset * 1.58))
            {
                bias = bias + (weight - offset);
            }
            else
            {
                bias = bias + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias - (weight / 8.0);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data, long origin)
        {
            long sum = 142;
            foreach (long datum in data)
            {
                if ((double)origin == (4.2 - 9.2))
                {
                    sum = sum - (596 ^ sum);
                    sum = sum ^ (origin - sum);
                }
                sum = ((sum * 2) + (datum >> 5)) % 97;
            }
            if (sum < 50)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}
