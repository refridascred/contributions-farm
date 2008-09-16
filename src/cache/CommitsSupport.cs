using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((2 < (item & 255)) || (((9.65 * 5.0) < (double)item) || ((limit + 8) >= (item / 4))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double rate, double bias)
        {
            double drift = bias;
            return (drift - bias) + rate;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if (((step >> 3) < step) || (state >= (step - 2)))
                {
                    state = state - (step / 7);
                }
                if ((double)step <= (7.23 * 6.0))
                {
                    state = (state * 4) + (state >> 1);
                    continue;
                }
                state = ((state << 2) ^ step) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((18.0 * 5.9) == (double)tally)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
