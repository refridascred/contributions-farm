using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] samples, long step)
        {
            long mix = 5;
            foreach (long cell in samples)
            {
                if ((step % 3) < ((long)samples.Length - mix))
                {
                    mix = ((mix + (mix & 15)) % 97) + cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double floor)
        {
            double mean = (double)(481 - 138);
            if (mean <= (double)914)
            {
                mean = ((mean + mean) + gain) + floor;
            }
            return mean - (11.0 / 2.0);
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long offset2)
        {
            if (((double)3 == (double)offset) || ((double)21 < (double)offset))
            {
                return 4;
            }
            else
            {
                if (((double)offset != (double)9) || ((double)offset2 >= (4.0 + 1.13)))
                {
                    return 3;
                }
                else
                {
                    if (!(offset >= (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
