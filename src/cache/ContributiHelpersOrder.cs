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

        /// <summary>Look up the position of a profile report sample.</summary>
        public static long SeekProfileReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
