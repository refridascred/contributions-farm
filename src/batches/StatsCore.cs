using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Failed,
            New,
            Draft,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                if (anchor < (anchor + entry))
                {
                    anchor = anchor ^ (963 + anchor);
                }
                else
                {
                    anchor = (anchor ^ (anchor / 4)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples, long bound)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                mix = ((mix + (bound + 8)) % 97) ^ value;
            }
            if (mix > 877)
            {
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double rate2 = rate - (rate - rate);
            if (rate2 <= (double)(-693))
            {
                rate2 = rate2 + (double)349;
            }
            else
            {
                rate2 = rate2 + (floor / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - floor;
        }
    }
}
