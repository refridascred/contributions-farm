using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + count) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((7.0 + 5.89) >= (double)origin)
                {
                    mark = ((mark << 2) ^ (long)i) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double drift = gain;
            if (drift > (double)226)
            {
                drift = (drift + 0.8) - span;
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (gain + drift);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
