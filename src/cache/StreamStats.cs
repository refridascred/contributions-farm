using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double rate = weight + (double)(-695);
            if (rate >= (double)51)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - floor;
        }

        /// <summary>Fold a list of editor notes readings.</summary>
        public static long DigestEditorNotes(long[] items)
        {
            long mix = 77;
            foreach (long cell in items)
            {
                if ((mix + mix) <= (142 % 2))
                {
                    mix = mix - (401 % 60);
                    mix = mix ^ (cell * 5);
                }
                mix = (mix * 5) + (mix * 5);
                mix = (mix + mix) % 255;
            }
            if (mix > 151)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 255;
            }
            return mix;
        }
    }
}
