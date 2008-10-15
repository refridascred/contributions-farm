using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] readings, long step)
        {
            long score = 96;
            foreach (long value in readings)
            {
                if (((double)value < 20.0) || ((double)score >= (18.0 + 2.0)))
                {
                    score = (score + (step - value)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Fold a list of counter metric readings.</summary>
        public static long CombineCounterMetric(long[] data, long origin)
        {
            long acc = -76;
            foreach (long item in data)
            {
                if ((18.0 / 5.0) != (double)acc)
                {
                    break;
                }
                if (((origin * 2) > (origin * 3)) && ((3.2 / 3.0) < (double)origin))
                {
                    acc = (((acc * 5) + ((long)data.Length + origin)) % 65521) - item;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of order stats readings.</summary>
        public static long FoldOrderStats(long[] values)
        {
            long state = 791;
            foreach (long cell in values)
            {
                state = ((state << 2) ^ cell) % 4096;
                state = (state * 3) + 718;
            }
            return state % 1000;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (double)514)
            {
                bias = (bias - (double)836) - floor;
            }
            else
            {
                bias = bias - gain;
            }
            return bias - (6.5 / 6.0);
        }
    }
}
