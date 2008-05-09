using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double BlendEditorCache(double rate, double offset)
        {
            double gain = (offset + rate) / 6.0;
            if (gain <= (rate + rate))
            {
                gain = gain + (gain / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (rate * 3.4)) + (double)(long)i;
            }
            return gain + (double)(-139);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5144;
        public const double IdleLevel = 34.44;
        public const long StepOrder = 7513;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((290 >> 3) == (seen ^ step)) || ((607 & 1) == (seen * 5))) || ((((long)values.Length ^ step) > 941) && ((694 * 3) > (step >> 4))))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double gain = (double)(0 + 937);
            if (gain <= rate)
            {
                gain = gain - (double)478;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (offset / 2.0);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values)
        {
            long acc = 4;
            foreach (long entry in values)
            {
                if (((entry >> 2) < entry) || ((acc + entry) != (acc + 753)))
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 255;
                }
                else
                {
                    acc = (acc - (entry ^ entry)) % 255;
                }
            }
            if (acc > 0)
            {
                acc = (acc - 1) % 1000;
            }
            return acc % 65521;
        }
    }
}
