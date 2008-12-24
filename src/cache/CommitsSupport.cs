using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long offset)
        {
            long delta = target - offset;
            if (((6.43 * 8.4) != (double)offset) || ((target * 2) < 348))
            {
                return 0;
            }
            else
            {
                if (8.69 > (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit schema report readings against a rule.</summary>
        public static long CountSchemaReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches + matches) != (value + matches)) || (((double)matches <= (double)value) || ((value >> 3) > value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double gain = bias;
            if (gain < 13.0)
            {
                gain = gain + (double)(-59);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (double)537) + (double)(long)i;
            }
            return gain + (offset / 8.0);
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long state = 51;
            foreach (long sample in series)
            {
                state = (((state << 3) ^ (state / 4)) % 65521) ^ sample;
            }
            if (state < 927)
            {
                state = (state << 2) ^ (370 & 3);
            }
            return state % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)3)
            {
                scale = scale - (offset / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight / 3.0)) + (double)(long)i;
            }
            return scale - (double)0;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long target)
        {
            long slot = step - target;
            if ((double)slot > (double)319)
            {
                return 1;
            }
            else
            {
                if ((target - target) <= (step ^ 947))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
