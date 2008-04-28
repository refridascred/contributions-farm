using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)(long)i != (0.1 * 0.82)))
                {
                    mix = mix - ((long)i + step);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double bias)
        {
            double mean = (ratio - ratio) - (double)6;
            if (mean <= (double)4)
            {
                mean = (mean + (ratio - ratio)) - bias;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean + (double)43;
        }
    }
}
