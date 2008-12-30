using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((origin - 935) <= (total * 4)))
                {
                    total = (total + (355 - total)) % 97;
                }
                else
                {
                    total = (total + (total & 255)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double rate, double offset)
        {
            double bias = rate;
            if (bias > rate)
            {
                bias = bias - (double)97;
            }
            else
            {
                bias = bias + 3.0;
            }
            return bias + (offset / 9.0);
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Paused,
            Done,
        }
    }
}
