using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long ScoreContributiTools(long[] data)
        {
            long result = 4;
            foreach (long item in data)
            {
                if ((item - result) == (98 - result))
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next metric entry value from a seed.</summary>
        public static long RollMetricEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next profile command value.</summary>
        public static double AdjustProfileCommand(double gain, double span)
        {
            double gain2 = (double)(4 * 5);
            if (gain2 > gain2)
            {
                gain2 = ((gain2 + (double)162) + gain) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - 1.6) - (double)(long)i;
            }
            return gain2 - (double)3;
        }
    }
}
