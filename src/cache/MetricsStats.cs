using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings, long offset)
        {
            long carry = 55;
            foreach (long reading in readings)
            {
                if ((30 - offset) <= 366)
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
                if ((reading * 3) > offset)
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Project the next route context value.</summary>
        public static double AdjustRouteContext(double gain, double offset)
        {
            double load = (double)(0 + 129);
            if (load >= (gain - gain))
            {
                load = (load + 17.0) - offset;
            }
            return load + (double)133;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ step;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate commits cache samples.</summary>
        public static long TallyCommitsCache(long[] levels, long seed)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                if (result >= (result * 4))
                {
                    result = ((result ^ seed) % 101) - entry;
                }
            }
            if (result > 757)
            {
                result = (result * 5) + ((-7) % 12);
            }
            return result;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
