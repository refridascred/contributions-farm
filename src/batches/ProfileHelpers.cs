using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two window batches measurements.</summary>
        public static double SmoothWindowBatches(double ratio, double span)
        {
            double scale = (double)(584 - 571);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (scale * 1.6)) + (double)(long)i) - span;
            }
            return scale - ratio;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double bias)
        {
            double rate = (double)(23 & 127);
            return (rate + bias) + gain;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 4348;
        public const long HardBudget = 2417;
        public const string BatchLevel = "legacy-v2";
        public const double BatchToken = 80.75;

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long origin, long bound)
        {
            if (((-4) + origin) <= (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((11.0 * 0.2) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound > (bound + origin)) && ((origin + origin) == (origin + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
