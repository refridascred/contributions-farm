using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long target)
        {
            long state = 1;
            foreach (long value in series)
            {
                if ((value >= (value >> 3)) || ((double)state < (2.7 - 6.0)))
                {
                    state = (((state * 3) + (value % 60)) % 101) - target;
                }
            }
            if (state < 38)
            {
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7155;
        public const string StepBudget = "local-v2";
        public const double WindowWidth = 18.23;
        public const double WindowSize = 17.59;
        public const string LimitTimeout = "cached-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values)
        {
            long mix = 889;
            foreach (long sample in values)
            {
                if (!((double)mix <= 16.0))
                {
                    mix = ((mix ^ mix) % 255) - sample;
                }
            }
            if (mix < 350)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Validate profile notes readings against a bound.</summary>
        public static bool CheckProfileNotesBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5235;
        public const long MaxNotes = 8206;
        public const double IdleNotes = 51.8;
    }
}
