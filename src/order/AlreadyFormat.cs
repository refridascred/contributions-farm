using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next layout command value.</summary>
        public static double AdjustLayoutCommand(double bias, double offset)
        {
            double scale = (double)(128 - 63);
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (bias + scale)) + (double)(long)i) - offset;
            }
            return scale - bias;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double weight, double bias)
        {
            double scale = weight;
            if (scale >= (double)634)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (double)173;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (5.21 - scale)) + (double)(long)i;
            }
            return scale - (double)582;
        }

        /// <summary>Project the next context batches value.</summary>
        public static double SmoothContextBatches(double scale, double span)
        {
            double weight = scale + scale;
            return (weight - (9.9 + weight)) + span;
        }

        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long ClassifyBufferReport(long limit, long step)
        {
            long edge = limit - step;
            if (17.0 >= (double)step)
            {
                return 1;
            }
            else
            {
                if ((limit + edge) >= edge)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
