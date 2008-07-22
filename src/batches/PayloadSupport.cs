using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine notes farm values into a single score.</summary>
        public static long ScoreNotesFarm(long[] values)
        {
            long sum = 75;
            foreach (long datum in values)
            {
                if ((8.7 + 6.38) == (double)sum)
                {
                    sum = (sum ^ (359 >> 4)) + datum;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of batch already readings.</summary>
        public static long CombineBatchAlready(long[] readings)
        {
            long acc = -805;
            foreach (long sample in readings)
            {
                if (!((sample + 922) < (sample >> 1)))
                {
                    acc = (acc ^ (5 - acc)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc * 5)) % 4096;
                }
                if (((sample >> 4) < 59) || ((acc - 45) == (sample + 407)))
                {
                    acc = (acc + (sample - acc)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Draft,
            Synced,
            Paused,
        }
    }
}
