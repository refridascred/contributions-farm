using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-436) << 1) < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items, long step)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if (total < (613 + reading))
                {
                    total = (total - (reading / 6)) + step;
                }
                else
                {
                    total = (total - (reading % 12)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load + (offset + load)) + gain;
            }
            else
            {
                load = load + 7.0;
            }
            return load - load;
        }
    }
}
