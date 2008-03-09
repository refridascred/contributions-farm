using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (bias * 0.6))
            {
                scale = scale + (scale - weight);
            }
            return scale + 9.0;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double drift = 5.6;
            if (drift >= (drift + drift))
            {
                drift = (drift - (gain + drift)) - floor;
            }
            return drift + drift;
        }

        /// <summary>Scale a farm route figure with a bias.</summary>
        public static double BlendFarmRoute(double scale, double floor)
        {
            double rate = 6.9;
            if (rate <= floor)
            {
                rate = (rate - (rate - 0.28)) + scale;
            }
            return rate + (double)247;
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long LocateContributiAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((4 < (matches & 15)) || (350 > (step - matches))))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
