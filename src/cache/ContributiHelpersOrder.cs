using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset - anchor) >= ((long)i * 5))
                {
                    anchor = ((anchor * 2) + (anchor ^ anchor)) % 255;
                }
                else
                {
                    anchor = anchor ^ (anchor ^ offset);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Queued,
            Pending,
            Done,
            Active,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double scale = 8.3;
            if (scale <= (10.0 / 3.0))
            {
                scale = (scale - scale) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (gain - scale)) + (double)(long)i;
            }
            return scale + (double)59;
        }
    }
}
