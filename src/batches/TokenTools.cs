using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double drift = 6.72;
            return ((drift - (double)319) + scale) + span;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long acc = 78;
            foreach (long sample in series)
            {
                if ((1.86 - 8.0) < (double)sample)
                {
                    acc = acc - (sample << 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
