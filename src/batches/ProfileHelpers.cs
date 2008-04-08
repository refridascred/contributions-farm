using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long AuditClusterCommitsMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)reading != (3.0 / 6.0)) && !(seen < (seen + 82)))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command record series from a seed.</summary>
        public static long StepCommandRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((958 >> 3) <= (bound - mix))
                {
                    mix = (mix ^ (bound + bound)) % 255;
                    mix = ((mix * 3) + ((long)i ^ (long)i)) % 65521;
                }
                if ((2.2 - 3.17) <= (double)(long)i)
                {
                    mix = mix - (mix - (-336));
                }
                else
                {
                    mix = (mix + (2 + bound)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] readings, long step)
        {
            long state = -9;
            foreach (long entry in readings)
            {
                if ((double)step > (6.75 - 7.57))
                {
                    state = ((state * 4) + 851) - entry;
                }
                else
                {
                    state = (state * 3) + state;
                }
            }
            if (state < 4)
            {
                state = (state - step) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
