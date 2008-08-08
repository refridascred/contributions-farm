using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series, long seed)
        {
            long sum = -523;
            foreach (long cell in series)
            {
                sum = (((sum << 2) ^ 6) ^ cell) - seed;
            }
            return sum;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long bound)
        {
            long diff = step - bound;
            if ((step + step) < (step & 127))
            {
                return 5;
            }
            else
            {
                if ((96 >> 2) <= (step / 9))
                {
                    return 6;
                }
                else
                {
                    if ((step << 1) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((diff << 2) > (step * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batches support samples.</summary>
        public static long OverlapBatchesSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)step < (20.0 * 5.46)) || !(step > sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
