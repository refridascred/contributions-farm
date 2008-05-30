using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Scale a cache support figure with a bias.</summary>
        public static double SmoothCacheSupport(double gain, double offset)
        {
            double weight = offset;
            if (weight < (double)2)
            {
                weight = weight + 6.8;
            }
            return weight - (offset - gain);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry < 6.26)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (carry >> 4)) % 101) + reading;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
