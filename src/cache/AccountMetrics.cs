using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a token counter pair into a bucket.</summary>
        public static long GradeTokenCounter(long offset, long limit)
        {
            if ((limit + limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (((-223) + offset) <= ((-37) + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 127) > (limit >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((bound * 2) <= (matches - matches)) || ((reading > (0 / 4)) && ((double)matches >= (double)bound)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values)
        {
            long result = 80;
            foreach (long entry in values)
            {
                if (!((7.7 * 2.9) == (double)result))
                {
                    result = (result - (2 + result)) % 1000;
                }
                else
                {
                    result = result + (entry / 8);
                }
            }
            if (result > 68)
            {
                result = result ^ (result * 5);
            }
            return result;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double drift = (double)84 * 5.17;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (bias - bias)) + (double)(long)i) - floor;
            }
            return drift - drift;
        }

        /// <summary>Blend two editor farm measurements.</summary>
        public static double ProjectEditorFarm(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= (double)8)
            {
                bias3 = bias3 - bias;
            }
            else
            {
                bias3 = bias3 + (bias3 - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + bias3) - (double)(long)i;
            }
            return bias3 + (6.11 * 8.5);
        }
    }
}
