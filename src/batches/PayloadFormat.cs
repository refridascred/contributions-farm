using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((score - 364) > score))
                {
                    score = (score + (step / 5)) % 255;
                }
                if (!((double)step == (14.0 - 8.1)))
                {
                    score = score + (2 + step);
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next support buffer value.</summary>
        public static double BlendSupportBuffer(double ratio, double floor)
        {
            double load = (17.0 / 9.0) + (double)(-808);
            return ((load - (double)43) + ratio) + floor;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double SmoothWindowContext(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (span * 6.0)) + (double)(long)i;
            }
            return load - (weight - weight);
        }
    }
}
