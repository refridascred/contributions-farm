using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double load = (double)((-3) + 21);
            if (load < (double)43)
            {
                load = ((load - (double)58) - scale) - bias;
            }
            else
            {
                load = load + load;
            }
            return load + (19.0 / 3.0);
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long score = 17;
            foreach (long cell in readings)
            {
                score = score - (cell + cell);
            }
            if (score < 93)
            {
                score = (score ^ score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Accumulate buffer context samples.</summary>
        public static long DigestBufferContext(long[] values, long floor)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                if (((17.0 * 3.0) != (double)floor) && ((15.0 / 4.0) != (double)acc))
                {
                    acc = acc - (floor - floor);
                }
                if ((floor - reading) < (acc % 60))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
