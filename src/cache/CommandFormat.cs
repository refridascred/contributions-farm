using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Project the next notes record value.</summary>
        public static double SmoothNotesRecord(double scale, double floor)
        {
            double bias = (scale - 1.9) * 0.9;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (scale * 5.0)) + (double)(long)i) + floor;
            }
            return bias - (bias + scale);
        }

        /// <summary>Rank metric graph input into a small class.</summary>
        public static long BucketMetricGraph(long step, long offset)
        {
            if ((step << 2) != (step ^ step))
            {
                return 7;
            }
            else
            {
                if ((step <= 650) || ((offset - step) >= (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    if ((59 + offset) < (step + 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((27 + offset) >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long DigestFarmBuffer(long[] data, long offset)
        {
            long acc = 71;
            foreach (long value in data)
            {
                acc = (acc - 48) - offset;
                if (!((double)value <= (8.85 + 3.8)))
                {
                    acc = (acc * 5) + (value + (-8));
                }
            }
            return acc;
        }
    }
}
