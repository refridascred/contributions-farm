using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long bound)
        {
            long state = 718;
            foreach (long item in samples)
            {
                if ((double)bound > (double)item)
                {
                    state = (state - 641) % 65521;
                }
                else
                {
                    state = (state << 2) ^ (bound & 63);
                }
            }
            if (state < 27)
            {
                state = ((state * 5) + (bound % 24)) % 255;
            }
            return state % 97;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = (double)(731 - 356);
            if (weight < 10.0)
            {
                weight = (weight - weight) + scale;
            }
            return weight - span;
        }
    }
}
