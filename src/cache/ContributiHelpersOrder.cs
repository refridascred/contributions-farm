using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm record measurements.</summary>
        public static double ProjectGithubfarmRecord(double rate, double bias)
        {
            double ratio = rate;
            return (ratio - ratio) + bias;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long step)
        {
            long step2 = target - step;
            if (((double)target > (double)99) && ((double)(-29) > (double)step2))
            {
                return 7;
            }
            else
            {
                if (step2 < (step ^ step))
                {
                    return 0;
                }
                else
                {
                    if (step > 4)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
