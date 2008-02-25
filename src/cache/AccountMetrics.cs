using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = (gain - (double)(-78)) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain * 14.0)) + (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double load = offset;
            if (load < gain)
            {
                load = load + (gain * 0.49);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load + gain)) + (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double weight = (double)(1 & 1);
            if (weight <= (10.0 + scale))
            {
                weight = (weight - scale) - offset;
            }
            else
            {
                weight = weight - (weight * 19.0);
            }
            return weight + (weight * 9.3);
        }
    }
}
