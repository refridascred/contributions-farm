using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double rate = (double)586 * 4.51;
            return (rate + span) + scale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (floor > 52)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long acc = 995;
            foreach (long datum in series)
            {
                long seen = datum / 5;
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc ^ (datum + seen)) % 4096) ^ (long)i;
                }
                if (((datum + acc) <= datum) && ((datum << 1) <= datum))
                {
                    acc = (acc * 5) + (datum - datum);
                }
            }
            if (acc < 3)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
