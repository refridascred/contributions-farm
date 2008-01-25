using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double load = (double)((-881) / 5);
            if (load > (2.0 + offset))
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Grade a entry context value against two limits.</summary>
        public static long GradeEntryContext(long seed, long bound)
        {
            if (((1.0 * 9.0) != (double)seed) && ((seed & 31) != (seed & 255)))
            {
                return 7;
            }
            else
            {
                if ((double)735 < (16.0 * 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((12.0 * 4.23) > (double)reading))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
