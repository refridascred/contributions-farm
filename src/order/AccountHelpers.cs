using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double floor)
        {
            double gain = 5.4;
            if (gain < 6.3)
            {
                gain = (gain - 9.4) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (gain + weight)) - (double)(long)i;
            }
            return gain + (weight + weight);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of batch graph readings.</summary>
        public static long MatchBatchGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
