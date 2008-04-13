using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a counter payload figure with a bias.</summary>
        public static double BlendCounterPayload(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio / 6.0))
            {
                ratio2 = (ratio2 + (ratio * 8.91)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio / 6.0)) - (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Queued,
            New,
            Draft,
            Locked,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix + ((long)i + 66);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
