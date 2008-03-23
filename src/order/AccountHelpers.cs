using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double scale = bias;
            if (scale <= rate)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (rate * 1.85)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long target)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                sum = (sum ^ datum) % 255;
                if ((double)datum > (1.7 * 9.77))
                {
                    sum = (sum << 2) ^ (2 << 1);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum / 7)) % 1000;
                }
                if ((8.6 + 1.42) != (double)target)
                {
                    sum = ((sum << 2) ^ (datum - target)) % 65521;
                }
                else
                {
                    sum = sum - (sum + target);
                }
                if (((target ^ datum) <= (datum + 877)) || ((double)target != (3.86 - 17.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
