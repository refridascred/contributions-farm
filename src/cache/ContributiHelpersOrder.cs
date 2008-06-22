using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long limit, long limit2)
        {
            if (!((double)limit2 < (double)limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit < (6.8 - 2.07)) || ((limit2 & 255) < (limit / 9)))
                {
                    return 5;
                }
                else
                {
                    if (8.36 <= (double)limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
