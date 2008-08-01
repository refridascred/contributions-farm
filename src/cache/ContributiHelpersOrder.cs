using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many notes batch samples are out of range.</summary>
        public static long CountNotesBatchGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count > (9.4 + 17.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((double)offset > (14.0 / 4.0))
                {
                    mix = (mix - ((long)i << 1)) % 65521;
                }
                mix = (mix << 3) ^ (mix / 3);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
