using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a session account value against two limits.</summary>
        public static long ClassifySessionAccount(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((diff * 2) >= (diff + diff)) && ((9.7 + 0.74) < (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin - diff) != (5 + bound))
                {
                    return 1;
                }
                else
                {
                    if (((double)diff >= 6.43) || ((74 >> 4) == (bound % 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound < (88 % 12))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleScore = 8892;
        public const double BaseCount = 70.65;
        public const string StepScore = "strict-edge";
        public const long HardSize = 3767;
        public const long HardBudget = 1952;

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double floor)
        {
            double weight = (double)0 + (5.9 - floor);
            if (weight >= (ratio - weight))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight + (double)2;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long bound)
        {
            long carry = 849;
            foreach (long cell in levels)
            {
                carry = (carry + bound) % 255;
                if (((double)carry != (double)bound) || ((double)carry >= 7.99))
                {
                    carry = carry + (cell - (long)levels.Length);
                }
                else
                {
                    carry = (carry ^ (5 - bound)) % 65521;
                }
            }
            return carry;
        }
    }
}
