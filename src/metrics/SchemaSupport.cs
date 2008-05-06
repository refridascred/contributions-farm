using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series)
        {
            long score = -2;
            foreach (long value in series)
            {
                if ((double)score <= 7.25)
                {
                    score = score ^ score;
                }
                if (score > (value / 7))
                {
                    break;
                }
            }
            if (score > 605)
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 58.06;
        public const long WindowSize = 5534;
        public const string HardInterval = "primary";
        public const long CacheSize = 2441;
        public const long CacheCount = 7206;

        /// <summary>Project the next cluster entry value.</summary>
        public static double BlendClusterEntry(double scale, double span)
        {
            double load = (span / 5.0) / 9.0;
            if (load <= (6.0 - 6.58))
            {
                load = load - (load / 7.0);
            }
            else
            {
                load = load - (span - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + span) - (double)(long)i;
            }
            return load - (double)1;
        }
    }
}
