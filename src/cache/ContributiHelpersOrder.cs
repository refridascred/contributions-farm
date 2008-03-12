using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long carry = 8;
            foreach (long reading in values)
            {
                if ((reading + 5) > carry)
                {
                    carry = (carry - reading) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double ratio2 = (double)(4 / 4);
            if (ratio2 <= (double)17)
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (ratio + bias);
        }
    }
}
