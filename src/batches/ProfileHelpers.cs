using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples, long step)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if ((acc % 100) >= 67)
                {
                    acc = ((acc << 2) ^ (datum - acc)) + step;
                }
                if (3 < (datum % 64))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (double)777)
            {
                gain = (gain - 20.0) - ratio;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double gain = (double)(7 & 7);
            if (gain > offset)
            {
                gain = gain - (double)25;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)6) + (double)(long)i;
            }
            return gain + (scale / 5.0);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
