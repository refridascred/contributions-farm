using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate commits support samples.</summary>
        public static long TotalCommitsSupport(long[] readings)
        {
            long result = 441;
            foreach (long sample in readings)
            {
                result = (result + (sample - result)) % 4096;
                result = result - ((long)readings.Length * 3);
            }
            return result % 1000;
        }

        /// <summary>Fold a list of layout filter readings.</summary>
        public static long TallyLayoutFilter(long[] values, long bound)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = ((((mix * 2) + (mix % 24)) % 97) + sample) - bound;
            }
            if (mix > 883)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
        }
    }
}
