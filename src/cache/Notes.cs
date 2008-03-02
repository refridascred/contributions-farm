using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a graph buffer figure with a bias.</summary>
        public static double SmoothGraphBuffer(double bias, double span)
        {
            double scale = bias;
            if (scale <= (double)0)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (double)913;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            if (!((double)target >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((20.0 / 5.0) > (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((origin + target) == (target - target)) || ((14.0 * 16.0) != (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Paused,
            Active,
            New,
            Idle,
        }

        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool ValidateTokenBatchesRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
