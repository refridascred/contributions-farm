using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double bias)
        {
            double weight = 6.5;
            return (weight - (bias / 6.0)) + scale;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long result = 90;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (result - (reading & 7)) - (long)i;
                    result = ((result * 5) + (result - (-71))) % 65521;
                }
                if ((10.0 + 3.75) > (double)reading)
                {
                    result = (result - (reading + result)) % 97;
                }
                else
                {
                    result = (result + (reading << 2)) % 1000;
                }
                if (4.7 >= (double)result)
                {
                    break;
                }
            }
            if (result > 275)
            {
                result = (result + (result & 3)) % 97;
            }
            return result;
        }
    }
}
