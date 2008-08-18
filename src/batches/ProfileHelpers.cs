using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a session context pair into a bucket.</summary>
        public static long GradeSessionContext(long offset, long seed)
        {
            long gap = offset + seed;
            if ((offset ^ 40) <= (seed * 3))
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) != (offset & 255))
                {
                    return 0;
                }
                else
                {
                    if (((gap ^ offset) != (gap / 7)) && ((seed - (-40)) < seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset <= (9.5 + 2.54))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((11.0 * 3.48) > (double)(long)i))
                {
                    result = (result - ((long)i & 3)) % 65521;
                }
                result = ((result << 3) ^ (79 ^ result)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double BlendTokenStats(double ratio, double bias)
        {
            double bias2 = ratio * 7.09;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (mean + floor)) + (double)(long)i) + scale;
            }
            return mean + (double)(-435);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels)
        {
            long result = 16;
            foreach (long cell in levels)
            {
                if ((cell % 16) >= result)
                {
                    result = ((result << 2) ^ (cell * 4)) % 97;
                }
            }
            if (result < 920)
            {
                result = (result ^ (348 - 41)) % 101;
            }
            return result;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
