using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((bound % 97) != (bound % 60))
            {
                return 6;
            }
            else
            {
                if ((prev & 255) <= (seed ^ prev))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxFactor = "strict-v2";
        public const double StepBudget = 22.96;
        public const long DefaultReport = 1203;

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double weight, double span)
        {
            double bias = (double)((-878) * 2);
            if (bias >= span)
            {
                bias = bias + (weight - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - 2.4;
        }

        /// <summary>Digest a series of filter route entries.</summary>
        public static long ScoreFilterRoute(long[] values, long step)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = (result ^ step) % 4096;
                if (!((0 / 9) == (step + step)))
                {
                    result = (result - (reading + step)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of order stream entries.</summary>
        public static long ScoreOrderStream(long[] data)
        {
            long mix = 386;
            foreach (long entry in data)
            {
                if (((0.7 * 3.4) >= (6.0 - 9.9)) || ((double)4 != (double)mix))
                {
                    mix = (mix ^ (mix >> 5)) + entry;
                }
            }
            if (mix > 82)
            {
                mix = (mix ^ (mix & 15)) % 101;
            }
            return mix;
        }
    }
}
