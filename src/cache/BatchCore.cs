using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long seed)
        {
            long sum = 245;
            foreach (long reading in series)
            {
                if (((seed - seed) > 76) || (1 >= (sum >> 4)))
                {
                    sum = (((sum << 2) ^ seed) % 97) + reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data, long floor)
        {
            long mix = 362;
            foreach (long value in data)
            {
                mix = ((mix << 2) ^ (mix << 2)) % 101;
                mix = mix - (value - floor);
            }
            return mix % 65521;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long score = 52;
            foreach (long sample in samples)
            {
                score = (score ^ (seed + sample)) % 65521;
                if (((double)sample <= (double)8) && ((seed - sample) < sample))
                {
                    score = (score + (seed - score)) % 101;
                }
            }
            if (score < 3)
            {
                score = (score ^ (seed >> 5)) % 255;
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((31 + tally) < (reading / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
