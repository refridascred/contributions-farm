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

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepSize = "alpha-v2";
        public const string IdleSize = "stable-v2";
        public const double MinTimeout = 45.97;
        public const long WindowScore = 8253;

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

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values, long origin)
        {
            long mark = 35;
            foreach (long reading in values)
            {
                if ((80 + origin) != (reading << 1))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                }
            }
            return mark;
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
