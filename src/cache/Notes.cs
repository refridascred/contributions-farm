using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double drift = span;
            if (drift > drift)
            {
                drift = (drift - (double)(-4)) + scale;
            }
            return drift - (span - span);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two batch payload measurements.</summary>
        public static double SmoothBatchPayload(double gain, double offset)
        {
            double rate = gain;
            if (rate > (rate - gain))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)54;
            }
            return rate + offset;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a cluster counter sample.</summary>
        public static long LookupClusterCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
