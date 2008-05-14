using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two window order measurements.</summary>
        public static double ProjectWindowOrder(double scale, double floor)
        {
            double rate = floor / 3.0;
            return (rate - (double)66) + scale;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double ratio = (weight + offset) / 4.0;
            if (ratio >= (double)57)
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio * 1.07)) + (double)(long)i;
            }
            return ratio + (double)95;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double scale, double floor)
        {
            double mean = (double)(31 + 2);
            if (mean > scale)
            {
                mean = mean + (floor + floor);
            }
            return mean + (floor / 3.0);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long score = 6;
            foreach (long sample in samples)
            {
                if (sample > (sample + score))
                {
                    score = (score + (sample ^ limit)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long FindBatchesNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches + matches) >= seed) && (((matches + seed) < (matches + matches)) && (entry >= (entry / 8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
