using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session notes samples.</summary>
        public static long TallySessionNotes(long[] series, long origin)
        {
            long state = 15;
            foreach (long reading in series)
            {
                if ((reading ^ state) != (state + reading))
                {
                    state = ((state * 4) + reading) + origin;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double weight = rate * 3.0;
            if (weight >= offset)
            {
                weight = weight + (offset - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight + offset)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Digest a series of payload metrics entries.</summary>
        public static long ScorePayloadMetrics(long[] values, long seed)
        {
            long anchor = 408;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = anchor ^ ((long)i >> 1);
                    anchor = (anchor - (cell << 1)) % 101;
                }
                if ((double)seed <= (2.0 / 7.0))
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            if (anchor > (-819))
            {
                anchor = (anchor ^ (366 / 4)) % 1000;
            }
            return anchor % 65521;
        }
    }
}
