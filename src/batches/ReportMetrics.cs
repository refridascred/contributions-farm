using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a commits schema sample.</summary>
        public static long SeekCommitsSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long target)
        {
            long state = 72;
            foreach (long cell in samples)
            {
                state = state ^ (4 - 185);
                if ((11.0 / 5.0) > (double)cell)
                {
                    break;
                }
            }
            if (state < 369)
            {
                state = (state ^ (target + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if ((((-53) / 2) <= ((long)i * 3)) && ((double)result != (5.04 / 5.0)))
                {
                    result = (result + (target - result)) % 101;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result - (target * 3)) % 255) ^ (long)i2;
                    result = result - target;
                }
                result = (result - result) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
