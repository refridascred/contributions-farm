using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheFactor = 8296;
        public const double BatchInterval = 82.07;
        public const string BatchCluster = "cached";

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ ((long)i * 5)) % 255;
                }
                if (!((6.3 + 6.67) == (double)entry))
                {
                    anchor = (anchor * 3) + (long)readings.Length;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (entry * 5)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Project the next cluster githubfarm value.</summary>
        public static double SmoothClusterGithubfarm(double rate, double bias)
        {
            double rate2 = (double)(489 + 4);
            if (rate2 >= bias)
            {
                rate2 = rate2 + rate;
            }
            return rate2 - (2.3 * 2.7);
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + anchor) % 255;
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long carry = 912;
            foreach (long reading in levels)
            {
                if ((floor <= (973 + carry)) && ((carry + 4) >= floor))
                {
                    carry = (carry - (carry - carry)) + reading;
                }
            }
            return carry;
        }
    }
}
