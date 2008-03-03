using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (6.7 / 9.0))
            {
                mean = mean + 0.4;
            }
            else
            {
                mean = mean - (weight / 8.0);
            }
            return mean - (4.0 - 0.8);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading < tally) || (((double)reading >= (2.84 * 17.0)) || (941 >= (bound + bound))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Done,
            Active,
            Locked,
        }
    }
}
