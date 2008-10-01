using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Retry,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Audit queue session readings against a rule.</summary>
        public static long TallyQueueSessionOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >= datum) || ((0 / 3) != ((long)samples.Length / 2)))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double rate = floor + gain;
            return rate - 2.0;
        }

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long TallyEditorContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - 33) >= (step + step))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }
    }
}
