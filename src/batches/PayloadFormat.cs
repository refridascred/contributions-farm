using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a session metric figure with a bias.</summary>
        public static double SmoothSessionMetric(double weight, double bias)
        {
            double load = (double)((-70) + 9);
            if (load <= load)
            {
                load = (load - (double)7) + weight;
            }
            else
            {
                load = load - load;
            }
            return load - (bias - load);
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
